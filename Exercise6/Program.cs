using Exercise6.Classes;
using Wantsome_Week_03.Handlers;

namespace Exercise6
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            int x = InputHandling.ReadValue("Number to calculate the sum: ");
            OutputHandling.Message("The sum of the digits of " + x + " is: " + SumOfDigits.Sum(x));
            OutputHandling.Question("Do you want to calculate the sum of the digits of another number? Y / N");
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
