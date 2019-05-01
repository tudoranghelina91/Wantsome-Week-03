using System;
using Wantsome_Week_03.Handlers;
using Exercise4.Classes;

namespace Exercise4
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            int arrLen = InputHandling.ReadCollectionLength();
            int[] arr = new int[arrLen];
            int index = 0;
            InputHandling.ReadCollectionElements(ref arr, arrLen, ref index);
            bool hasDuplicates = DuplicatesInArray.HasDuplicates(arr, arrLen);
            if (hasDuplicates)
            {
                OutputHandling.Message("The array contains duplicates", ConsoleColor.Magenta);
            }

            else
            {
                OutputHandling.Message("The array does not contain duplicates", ConsoleColor.Cyan);
            }

            OutputHandling.Question("Do you want to check another array for duplicates? Y / N");
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
