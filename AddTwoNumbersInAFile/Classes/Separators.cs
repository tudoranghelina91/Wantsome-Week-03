using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbersInAFile.Classes
{
    class Separators
    {
        public static char[] GenerateSeparators()
        {
            string separator = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ~!@#$%^&*(),./;'\\[]-=_+<>?:\"|{}\t\n\r^ ";
            return separator.ToCharArray(); 
        }
    }
}
