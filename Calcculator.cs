using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    internal class Calculator
    {
        public int CountWords(string sentence)
        {
            if (sentence == null || sentence.Length == 0) return 0;
            
            string[] words = sentence.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
