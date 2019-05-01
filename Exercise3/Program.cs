using System;
using Wantsome_Week_03.Handlers;
using Exercise3.Classes;

namespace Exercise3
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            int x = InputHandling.ReadValue("Type in a value to calculate it's factorial: ");
            Console.WriteLine("How do you want to calculate the factorial? R - Recursion, I - Iteration");
            Factorial.CalculateFactorial(x);
            OutputHandling.Question("Do you want to determine the factorial of another number? Y / N");
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
