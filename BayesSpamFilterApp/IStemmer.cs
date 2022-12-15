using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayesSpamFilterApp
{
    internal interface IStemmer
    {
        string GetStem(string word);
    }
}
