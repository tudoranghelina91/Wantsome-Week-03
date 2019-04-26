using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6.Classes
{
    class SumOfDigits
    {
        public static int Sum(int n)
        {
            int s = 0;

            if (n == 0)
            {
                return s;
            }

            else
            {
                return s + n % 10 + Sum (n / 10);
            }
        }
    }
}
