using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;
using Exercise2.Classes;

namespace Exercise2
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            int arrLength = InputHandling.ReadCollectionLength();
            int sum = InputHandling.ReadValue("Input sum: ");
            int[] array = new int[arrLength];
            int index = 0;
            InputHandling.ReadCollectionElements(ref array, arrLength, ref index);
            PairsEqualToSum.PrintElements(array, arrLength, sum);
            OutputHandling.Question("Do you want to check other array if the sum of elements is equal to given elements in an array? Y / N");
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
