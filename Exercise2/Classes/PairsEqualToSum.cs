using System;
using Wantsome_Week_03.Handlers;

namespace Exercise2.Classes
{
    class PairsEqualToSum
    {
        public static void PrintElements(int[] arr, int arrLen, int sum)
        {
            bool sumfound = false;
            for (int i = 0; i < arrLen - 1; i++)
            {
                for (int j = i + 1; j < arrLen; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        sumfound = true;
                        Console.WriteLine("{0} + {1} = {2}", arr[i], arr[j], sum);
                    }
                }
            }

            if (!sumfound)
            {
                OutputHandling.Message("NO ELEMENTS FOUND", ConsoleColor.DarkGreen);
            }
        }
    }
}
