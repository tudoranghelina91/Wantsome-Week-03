using System;
using Wantsome_Week_03.Handlers;
using Exercise15.Classes;

namespace Exercise15
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            int n = InputHandling.ReadValue("Number to check if it is ARMSTRONG or NOT: ");
            bool armstrong = Armstrong.IsArmstrong(n);

            if (armstrong)
            {
                OutputHandling.Message(n + " is an armstrong number",ConsoleColor.Green);
            }

            else
            {
                OutputHandling.Message(n + " is not an armstrong number", ConsoleColor.Magenta);
            }

            OutputHandling.Question("Do you want to check another number if it is an Armstrong number? Y / N");
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
