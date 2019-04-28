using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;
using Wantsome_Week_03.NumericOperation;
using Exercise12.Classes;

namespace Exercise12
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            int n = InputHandling.ReadValue("Number to display set bits: ");
            int[] nToBase2 = BaseConversion.ConvertBase10ToBaseX(n, 2);
            OutputHandling.Message("The number of bits that are set for " + n + " is " + SetBits.CountSetBits(n));
            OutputHandling.PrintArray(nToBase2, nToBase2.Length, "Representation of " + n + " in base 2 is: ", "", "0b", false);
            OutputHandling.Question("Do you want to calculate the number of set bits of a nother number? Y / N");
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
