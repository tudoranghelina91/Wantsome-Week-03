using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AddTwoNumbersInAFile.Classes
{
    class Calculus
    {
        public static int CalculateSum(string fileContents)
        {
            string pattern = @"\d+";
            int s = 0;

            foreach (Match number in Regex.Matches(fileContents, pattern))
            {
                // convert each string to an integer and add it to sum
                s += Convert.ToInt32(number.Value);
            }

            return s;
        }
    }
}
