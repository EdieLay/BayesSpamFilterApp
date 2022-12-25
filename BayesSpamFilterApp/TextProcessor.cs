using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayesSpamFilterApp
{
    public delegate string GetStemDelegate(string value); // ОПРЕДЕЛЕНИЕ ДЕЛЕГАТА
    internal class TextProcessor
    {
        public GetStemDelegate GetStem { get; set; }

        public TextProcessor() 
        { 
            GetStem = (str) =>  str;
        }

        public TextProcessor(GetStemDelegate GetStem) 
        { 
            this.GetStem = GetStem;
        }

        public List<string> ProcessLineDB(string line)
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

            line = line.Remove(0, 5);

            List<string> words = ProcessWords(line);
            words.Insert(0, isspam.ToString());

            return words;
        }

        public List<string> ProcessWords(string line)
        {
            line = line.ToLower().Replace("ё", "е"); // удаляем начало из 5 букв, приводим в нижний регистр, меняем ё на е

            char[] separators = new char[] { ' ', ',', '.', '-', '(', ')', '/', ':', ';', '!', '?', '*', '"', '>', '<', '\'', '`' };
            string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries); // разделяем строчку на слова, удаляя пустые строки
            List<string> processedwords = new List<string>();

            string temp;
            foreach (string word in words) // перебираем слова в текущей строке
            {
                if (!IsRussian(word))
                    continue;

                temp = word;
                temp = GetStem(temp); // проводим стемминг
                processedwords.Add(temp);
            }
            processedwords = processedwords.Distinct().ToList();
            return processedwords;
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
