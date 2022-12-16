using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace BayesSpamFilterApp
{
    
    internal class WordsDB
    {
        public Dictionary<string, SpamHamFreq> wordsfreq { get; set; }
        public List<string> lines { get; set; }
        

        public WordsDB()
        {
            wordsfreq = new();
            lines = new List<string>();
        }

        public void GetLinesFromDB()
        { 
            using (var reader = new StreamReader("..\\..\\..\\txtfiles\\spamdb.txt", System.Text.Encoding.Default)) // файл с письмами
            {
                string? line;

                while ((line = reader.ReadLine()) != null) // считываем строчки, у которых начало либо "Мэри,...", либо "спам,..."
                {
                    lines.Add(line);
                }

                return;
            }            
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

            string[] words;
            char[] separators = new char[] { ' ', ',', '.', '-', '(', ')', '/', ':', ';', '!', '?', '*', '"', '>', '<', '\'', '`' };
            line = line.Remove(0, 5).ToLower().Replace("ё", "е"); // удаляем начало из 5 букв, приводим в нижний регистр, меняем ё на е
            words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries); // разделяем строчку на слова, удаляя пустые строки

            foreach (string word in words) // перебираем слова в текущей строке
            {
                if (!IsRussian(word))
                    continue;

                string temp = word;
                temp = GetStem(temp); // проводим стемминг

                AddWordToDictionary(temp, isspam);
            }
        }


        bool IsRussian(string word) // проверка на то, все ли буквы в слове русские
        {
            foreach (char letter in word)
            {
                if (!(letter >= 'а' && letter <= 'я')) // оставляем только слова с русскими буквами
                    return false;
            }
            return true;
        }


        public void AddWordToDictionary(string word, bool isspam)
        {
            if (wordsfreq.ContainsKey(word)) // если такое слово уже есть в словаре, то вызываем метод NewEntrance()
            {
                wordsfreq[word].NewEntrance(isspam);
            }
            else // если нет, то вызываем для него конструктор
            {
                wordsfreq[word] = new SpamHamFreq();
                wordsfreq[word].NewEntrance(isspam);
            }
        }
    }
}
