using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayesSpamFilterApp
{
    class InvalidMessageException : Exception // ОПРЕДЕЛЕНИЕ ИСКЛЮЧЕНИЯ
    {
        public InvalidMessageException(string message)
            : base(message) { }
    }

    public enum FilterHarshness // процент, свыше которого письмо определится как спам (чем больше, тем меньше шанс срабатывания)
    {
        Мягкий = 65,
        Средний = 50,
        Жесткий = 35
    } // ОПРЕДЕЛЕНИЕ ПЕРЕЧИСЛЕНИЯ

    internal class SpamFilter
    {
        WordsDB wordsdb { get; set; }
        public TextProcessor txtproc { get; set; }


        public SpamFilter()
        {
            wordsdb = new();
            wordsdb.GetLinesFromDB();
            txtproc = new TextProcessor();
        }


        public double ProbOfSpam(List<string> words_in_msg) 
        {
            double spam_prob = 0, ham_prob = 0; // вероятности, что сообщение спам или хэм
            foreach (var word in wordsdb.wordsfreq)
            {
                if (words_in_msg.Contains(word.Key)) // если слово из словаря есть в сообщении, то прямое событие, иначе обратное
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

        public List<string> GetMessageStems(string message)
        {
            List<string> words_in_msg = txtproc.ProcessWords(message);
            if (!words_in_msg.Any())
                throw new InvalidMessageException("Сообщение должно содержать хотя бы одно русское слово");
            words_in_msg = words_in_msg.Distinct().ToList();
            return words_in_msg;
        }

        public void UpdateFrequencies()
        {
            List<string> words;
            bool isspam;
            
            wordsdb.wordsfreq = new(); // создаём новую, чтоб не накапливались частоты + слова там были бы с разным стеммингом
            SpamHamFreq.num_of_spam = 0;
            SpamHamFreq.num_of_ham = 0;

            foreach (string line in wordsdb.lines) // в wordsdb.lines хранятся строчки из БД с сообщениями
            {
                words = txtproc.ProcessLineDB(line); // возвращает список стем слов, где нулевой элемент показывает, сообщение спам или нет
                isspam = words[0] == "True";
                words.RemoveAt(0); // удаляем вспомогательный элемент

                foreach (string word in words)
                    wordsdb.AddWordToDictionary(word, isspam);
            }

            foreach (var word in wordsdb.wordsfreq) // считаем относитульную вероятность встречи слова для каждого типа сообщений
            {
                word.Value.spam_prob = (((double)word.Value.met_in_spam + 1) / ((double)SpamHamFreq.num_of_spam + 2)); // добавляем 1 в числитель и 2 в знаменатель
                word.Value.ham_prob = (((double)word.Value.met_in_ham + 1) / ((double)SpamHamFreq.num_of_ham + 2));    // чтобы не было нулевых вероятностей
            }
        }

    }


}
