using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;
using Exercise11.Classes;
namespace Exercise11
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            int n = InputHandling.ReadValue("Number to print from fibonacci sequence, starting at 1: ");
            Console.WriteLine(Fibonacci.FindFiboInSequence(n));
            OutputHandling.Question("Do you want to find another number in a fibonacci sequence? Y / N");
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
