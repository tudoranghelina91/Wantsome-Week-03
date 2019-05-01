using System;
using Wantsome_Week_03.Handlers;
using Exercise17.Classes;

namespace Exercise17
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            int n = InputHandling.ReadValue("Number to check if it is a palindrome or not: ");
            bool isPalindrome = Palindrome.IsPalindrome(n);

            if (isPalindrome)
            {
                OutputHandling.Message(n + " is a palindrome!", ConsoleColor.Green);
            }

            else
            {
                OutputHandling.Message(n + " is not a palindrome!", ConsoleColor.Red);
            }

            OutputHandling.Question("Do you want to check if another number is a palindrome? Y / N");
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
