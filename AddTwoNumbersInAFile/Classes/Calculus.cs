using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbersInAFile.Classes
{
    class Calculus
    {
        public static int CalculateSum(string[] fileContents)
        {
            int s = 0;

            foreach (string numberString in fileContents)
            {
                // convert each string to an integer and add it to sum
                s += Convert.ToInt32(numberString);
            }

            return s;
        }
    }
}
