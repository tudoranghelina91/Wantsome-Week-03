using System;
using Wantsome_Week_03.Handlers;
using Exercise16.Classes;

namespace Exercise16
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            int n = InputHandling.ReadValue("Number to check if it is a prime number or not: ");
            bool isPrime = Prime.IsItPrime(n);

            if (isPrime)
            {
                OutputHandling.Message(n + " is a prime number!", ConsoleColor.Green);
            }

            else
            {
                OutputHandling.Message(n + " is not a prime number!", ConsoleColor.Red);
            }

            OutputHandling.Question("Do you want to check if another number is a prime number or not? Y / N");
            programRunning = InputHandling.QuestionOptions();
        }

        static void Main(string[] args)
        {
            bool programRunning = true;
            while (programRunning)
            {
                RunProgram(ref programRunning);
            }
        }
    }
}
