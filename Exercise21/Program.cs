using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;
using Wantsome_Week_03.ArrayOperations;

namespace Exercise21
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            OutputHandling.Message("This program accepts an array and sorts it using Bubble Sort");

            int arrLen = InputHandling.ReadCollectionLength();
            int[] arr = new int[arrLen];
            int lastFailIndex = 0;

            InputHandling.ReadCollectionElements(ref arr, arrLen, ref lastFailIndex);
            Sorting.BubbleSort(ref arr, arrLen);
            OutputHandling.PrintArray(arr, arrLen, "Sorted array using Bubble sort: ");
            OutputHandling.Question("Do you want to sort another array with Bubble sort? Y / N");

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
