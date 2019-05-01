namespace Exercise15.Classes
{
    class Armstrong
    {
        public static bool IsArmstrong(int n)
        {
            int armstrong = 0;
            if (n < 10)
            {
                return true;
            }

            else if (n >= 10 && n < 100)
            {
                return false;
            }

            else
            {
                int m = n;
                int digitCount = 0;
                while (m != 0)
                {
                    m /= 10;
                    digitCount++;
                }

                m = n;

                while (m != 0)
                {
                    int x = 1;
                    for (int i = 1; i <= digitCount; i++)
                    {
                        x *= m % 10;
                    }

                    armstrong += x;
                    m /= 10;
                }

                if (armstrong == n)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

        }
    }
}
