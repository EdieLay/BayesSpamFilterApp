using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayesSpamFilterApp
{
    internal class StemmerStemka : IStemmer
    {
        Dictionary<string, int> ModelsWordEndings { get; set; }
        char[] VowelLetters = {
            'а', 'е', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я'
        };

        public StemmerStemka()
        {
            ModelsWordEndings = new();
            using (var reader = new StreamReader("..\\..\\..\\txtfiles\\ModelsWordEnding.txt", System.Text.Encoding.Default))
            {
                string? line;
                string[] w;
                while ((line = reader.ReadLine()) != null)
                {
                    w = line.ToLower().Replace("ё", "е").Split(" ");
                    if (Convert.ToInt32(w[1]) <= 300) break;
                    try
                    {
                        ModelsWordEndings.Add(w[0], Convert.ToInt32(w[1]));
                    }
                    catch (ArgumentException)
                    {
                        ModelsWordEndings[w[0]] += Convert.ToInt32(w[1]);
                    }
                }
            }
        }


        bool ComplianceBasis(string word) // основа >= 2 и есть хотя бы одна гласная
        {
            bool flagCompliance = false;
            int wlen = word.Length;
            for (int i = 0; i < wlen; i++)
            {
                for (int j = 0; j < VowelLetters.Length; j++)
                {
                    if (word[i] == VowelLetters[j])
                    {
                        flagCompliance = true;
                        break;
                    }
                }
                if (flagCompliance) break;
            }
            return (flagCompliance && (wlen >= 2));
        }

        public string GetStem(string word)
        {
            int max = 0;
            int wlen = word.Length;
            foreach (var model in ModelsWordEndings) // итерации по массиву окончаний
            {
                string wordTest = word;
                bool flagEqually = true;
                string modelword = model.Key;
                int mwlen = modelword.Length;
                if (mwlen < wlen)
                {
                    flagEqually = true;
                    for (int j = mwlen - 1; j >= 0; j--) // итерации по концу слова
                        if (modelword[j] != word[wlen - mwlen + j])
                        {
                            flagEqually = false;
                            break;
                        }
                    if (flagEqually && mwlen > max && ComplianceBasis(wordTest[..^max]))
                    {
                        max = mwlen;
                    }
                }
            }
            return word[..^max];
        }
    }
}
