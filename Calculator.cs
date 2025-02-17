using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOrder
{
    public class Calculator
    {
        public bool IsInOrder (string str)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] < str[i - 1])
                    return false;
            }
            return true;
        }
    }
}
