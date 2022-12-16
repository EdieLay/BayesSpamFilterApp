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
