using System;

namespace Exercise16.Classes
{
    class Prime
    {
        public static bool IsItPrime(int n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }

            else if (n % 2 == 0 && n != 2)
            {
                return false;
            }

            else
            {
                for (int i = 3; i <= Math.Sqrt(n); i += 2)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
