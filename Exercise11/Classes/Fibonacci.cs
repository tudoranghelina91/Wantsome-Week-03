namespace Exercise11.Classes
{
    class Fibonacci
    {
        public static int FindFiboInSequence(int n)
        {
            int x = 1;
            int y = 1;

            if (n > 2)
            {
                int finalNumber = 0;
                int i = 3;
                while (i <= n)
                {
                    if (i <= n)
                    {
                        x += y;
                        finalNumber = x;
                        i++;
                    }

                    if (i <= n)
                    {
                        y += x;
                        finalNumber = y;
                        i++;
                    }
                }

                return finalNumber;
            }

            return 1;
        }
    }
}
