using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.NumericOperation;

namespace Exercise17.Classes
{
    class Palindrome
    {
        public static bool IsPalindrome(int n)
        {
            int nRev = ReverseNumber.Reverse(n);
            if (nRev == n)
            {
                return true;
            }

            return false;
        }
    }
}
