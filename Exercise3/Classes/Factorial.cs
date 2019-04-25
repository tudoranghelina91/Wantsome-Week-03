using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;
using System.Diagnostics;

namespace Exercise3.Classes
{

    class Factorial
    {
        static double FactorialIt(int x)
        {
            double factorialofx = 1;
            for (int i = 2; i <= x; i++)
            {
                factorialofx *= i;
            }

            return factorialofx;
        }

        static double FactorialRec(int x)
        {
            if (x == 1)
            {
                return 1;
            }

            else
            {
                return x * FactorialRec(x - 1);
            }
        }

        public static void CalculateFactorial(int x)
        {
            ConsoleKeyInfo cki = Console.ReadKey();

            if (cki.Key.Equals(ConsoleKey.I))
            {
                var watch = Stopwatch.StartNew();
                OutputHandling.Message("The factorial of " + x + " is " + FactorialIt(x), ConsoleColor.Green);
                watch.Stop();
                var elapsed = watch.Elapsed;
                OutputHandling.Message("Time elapsed for Iterative approach: " + elapsed.ToString());
            }

            else if (cki.Key.Equals(ConsoleKey.R))
            {
                var watch = Stopwatch.StartNew();
                OutputHandling.Message("The factorial of " + x + " is " + FactorialRec(x), ConsoleColor.Green);
                watch.Stop();
                var elapsed = watch.Elapsed;
                OutputHandling.Message("Time elapsed for Recursive approach: " + elapsed.ToString());
            }
        }
    }
}
