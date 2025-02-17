//Emilynn Molesky
//2/16/25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels
{
    public class Calculator
    {
        public string FirstNVowels(string str, int n)
        {
            string vowels = "aeiouAEIOU";
            string result = "";
            int count = 0;

            foreach (char c in str)
            {
                if (vowels.Contains(c))
                {
                    result += c;
                    count++;

                    if (count == n)
                    {
                        return result;
                    }
                }

            }
            return "Invalid";
        }
    }
}
