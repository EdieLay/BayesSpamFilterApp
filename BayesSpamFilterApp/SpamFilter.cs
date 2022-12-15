using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayesSpamFilterApp
{
    public delegate string GetStemDelegate(string value);

    public enum FilterHarshness // процент, свыше которого письмо определится как спам (чем больше, тем меньше шанс срабатывания)
    {
        Мягкий = 60,
        Средний = 50,
        Жесткий = 40
    }

    internal class SpamFilter
    {
        WordsDB wordsdb { get; set; }
        GetStemDelegate GetStem;

        public SpamFilter(GetStemDelegate GetStem)
        {
            wordsdb = new();
            wordsdb.UpdateWordsFrequencies(GetStem);
        }

        public bool IsSpam(string[] words_in_mes, FilterHarshness percent)
        {
            double prob = (double)percent / 100;
            return ProbOfSpam(words_in_mes) >= prob;
        }

        double ProbOfSpam(string[] words_in_mes) 
        {
            double spam_prob = 0, ham_prob = 0; // вероятности, что сообщение спам или хэм
            foreach (var word in wordsdb.wordsfreq)
            {
                if (words_in_mes.Contains(word.Key)) // если слово из словаря есть в сообщении, то прямое событие, иначе обратное
                {
                    spam_prob += Math.Log(word.Value.spam_prob); // считаем сумму логарифмов вероятностей, т.к. это аналогично умножению вероятностей
                    ham_prob += Math.Log(word.Value.ham_prob);   // потом просто экспоненту возведём в эту степень
                }
                else
                {
                    spam_prob += Math.Log(1.0 - word.Value.spam_prob);
                    ham_prob += Math.Log(1.0 - word.Value.ham_prob);
                }
            }
            double e_spam_prob = Math.Exp(spam_prob);
            double e_ham_prob = Math.Exp(ham_prob);

            return e_spam_prob / (e_spam_prob + e_ham_prob);
        }

        void ProcessLine(string line, GetStemDelegate GetStem)
        {
            bool isspam;

            if (line[0] == 'М') // если начинается на М, то это не спам
            {
                isspam = false;
                SpamHamFreq.num_of_ham++;
            }
            else
            {
                isspam = true;
                SpamHamFreq.num_of_spam++;
            }

            List<string> words = ProcessWords(line);
            
            foreach (string word in words)
                wordsdb.AddWordToDictionary(word, isspam);
        }

        public List<string> ProcessWords(string line)
        {
            line = line.Remove(0, 5).ToLower().Replace("ё", "е"); // удаляем начало из 5 букв, приводим в нижний регистр, меняем ё на е

            char[] separators = new char[] { ' ', ',', '.', '-', '(', ')', '/', ':', ';', '!', '?', '*', '"', '>', '<', '\'', '`' };
            string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries); // разделяем строчку на слова, удаляя пустые строки
            List<string> russianwords = new List<string>();

            foreach (string word in words) // перебираем слова в текущей строке
            {
                if (!IsRussian(word))
                    continue;

                string temp = word;
                temp = GetStem(temp); // проводим стемминг
                russianwords.Add(temp);
            }
            return russianwords;
        }

        public bool IsRussian(string word) // проверка на то, все ли буквы в слове русские
        {
            foreach (char letter in word)
            {
                if (!(letter >= 'а' && letter <= 'я')) // оставляем только слова с русскими буквами
                    return false;
            }
            return true;
        }


    }


}
