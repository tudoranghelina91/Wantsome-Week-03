using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;
using Wantsome_Week_03.ArrayOperations;
using Exercise4.Classes;

namespace Exercise4
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            int arr1Len = InputHandling.ReadArrayLength("Length of first array: ");
            int arr2Len = InputHandling.ReadArrayLength("Length of second array: ");

            int[] array1 = new int[arr1Len];
            int[] array2 = new int[arr2Len];
            int arr1Index = 0;
            int arr2Index = 0;

            OutputHandling.Message("Elements of first array", ConsoleColor.Blue);
            InputHandling.ReadArrayElements(ref array1, arr1Len, ref arr1Index);
            OutputHandling.Message("Elements of second array", ConsoleColor.Blue);
            InputHandling.ReadArrayElements(ref array2, arr2Len, ref arr2Index);

            // Sort arrays
            Sorting.BubbleSort(ref array1, arr1Len);
            Sorting.BubbleSort(ref array2, arr2Len);

            // Remove duplicate elements from arrays
            DuplicateRemoval.RemoveDuplicates(ref array1, ref arr1Len);
            DuplicateRemoval.RemoveDuplicates(ref array2, ref arr2Len);

            // Print common elements
            CommonElementsInArray.PrintCommonElements(array1, arr1Len, array2, arr2Len);            

            OutputHandling.Question("Do you want to find more common elements in other arrays? Y / N");
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
