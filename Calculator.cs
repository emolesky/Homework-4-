//Emilynn Molesky
//2/16/25
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextLetter
{
    public class Calculator
    {
        public string Move(string str)
        {
            string result = "";

            foreach(char c in str)
            {
                result += (char)(c + 1);

            }
            return result;
        }
    }
}
