using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;
using Wantsome_Week_03.ArrayOperations;

namespace Exercise7
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            int arrLen = InputHandling.ReadArrayLength();
            int[] arr = new int[arrLen];
            int index = 0;
            InputHandling.ReadArrayElements(ref arr, arrLen, ref index);
            int[] freqArray = FrequencyOfElements.GenerateFrequencyArray(arr, arrLen);
            int maxIndex = MaxMinArray.MaxIndex(freqArray, freqArray.Length);
            OutputHandling.Message("The element with the most occurences inside the array is " + maxIndex, ConsoleColor.Magenta);
            OutputHandling.Question("Do you want to find another value in an array with the most numbers of occurences? Y / N");
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
