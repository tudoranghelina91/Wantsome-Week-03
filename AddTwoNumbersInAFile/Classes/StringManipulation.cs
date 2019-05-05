using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbersInAFile.Classes
{
    class StringManipulation
    {
        public static string[] SplitString(string inputString, char[] separators)
        {
            return inputString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
