using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wantsome_Week_03.StringOperations
{
    public class Conversion
    {
        public static char[] ConvertToCharArray(string s)
        {
            char[] sToChar = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                sToChar[i] = s[i];
            }

            return sToChar;
        }
    }
}
