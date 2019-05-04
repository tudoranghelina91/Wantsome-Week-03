using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;
using LeapYear.Classes;

namespace LeapYear
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            int year = InputHandling.ReadValue("Year to check if it is leap or not: ");
            if (Leap.IsLeap(year))
            {
                OutputHandling.Message(year + " is a leap year", ConsoleColor.Green);
            }

            else
            {
                OutputHandling.Message(year + " is not a leap year", ConsoleColor.Red);
            }

            OutputHandling.Question("Do you want to check another year if it is leap? Y / N");
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
