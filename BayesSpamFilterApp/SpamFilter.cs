using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayesSpamFilterApp
{
    public delegate string GetStemDelegate(string value);

    public enum FilterHarshness
    {
        Мягкий = 40,
        Средний = 50,
        Жесткий = 60
    }

    internal class SpamFilter
    {
        WordsDB words { get; set; }

        public SpamFilter(GetStemDelegate GetStem)
        {
            words = new(GetStem);
            words.UpdateWordsFrequencies();
        }

        double ProbOfSpam(string[] words_in_mes) // можно сделать сразу bool и в конце возвращать сравнение с 0.5 или другим числом
        {
            double spam_prob = 0, ham_prob = 0; // вероятности, что сообщение спам или хэм
            foreach (var word in words.wordsfreq)
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
    }

    /*public bool IsSpam(string[] words_in_mes, FilterHarshness percent)
    {
        double prob = (double)percent / 100;
        if ()
    }*/
}
