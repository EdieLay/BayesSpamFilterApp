using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayesSpamFilterApp
{
    internal class SpamHamFreq
    {
        public static int num_of_spam { get; set; } = 0;
        public static int num_of_ham { get; set; } = 0;
        public int met_in_spam { get; set; }
        public int met_in_ham { get; set; }
        public double spam_prob { get; set; }
        public double ham_prob { get; set; }

        public SpamHamFreq()
        {
            met_in_spam = 0;
            met_in_ham = 0;
            spam_prob = 0;
            ham_prob = 0;
        }

        public void NewEntrance(bool isspam)
        {
            if (isspam)
                met_in_spam++;
            else
                met_in_ham++;
        }
    }
}
