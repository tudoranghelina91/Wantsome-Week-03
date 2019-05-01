using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;
using Wantsome_Week_03.ArrayOperations;

namespace Exercise19
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            int arrLen = InputHandling.ReadCollectionLength();
            int[] arr = new int[arrLen];
            int lastFailIndex = 0;
            InputHandling.ReadCollectionElements(ref arr, arrLen, ref lastFailIndex);
            int pivot = InputHandling.ReadCollectionIndex(arrLen, "Set pivot point: ");
            int[] arrRotated = ArrayManipulation.RotateArray(arr, arrLen, pivot);
            OutputHandling.PrintArray(arrRotated, arrRotated.Length, "Rotated array: ");
            OutputHandling.Question("Do you want to rotate another array? Y / N");
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
