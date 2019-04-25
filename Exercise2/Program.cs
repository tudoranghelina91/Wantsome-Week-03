using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;

namespace Exercise2
{
    class Program
    {
        static void PrintElements(int[] arr, int arrLen, int sum)
        {
            bool sumfound = false;
            for (int i = 0; i < arrLen-1; i++)
            {
                for (int j = i + 1; j < arrLen; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        sumfound = true;
                        Console.WriteLine("{0} + {1} = {2}", arr[i], arr[j], sum);
                    }
                }
            }

            if (!sumfound)
            {
                OutputHandling.Message("NO ELEMENTS FOUND", ConsoleColor.DarkGreen);
            }
        }



        static void RunProgram(ref bool programRunning)
        {
            int arrLength = InputHandling.ReadArrayLength();
            int sum = InputHandling.ReadValue("Input sum: ");
            int[] array = new int[arrLength];
            int index = 0;
            InputHandling.ReadArrayElements(ref array, arrLength, ref index);
            PrintElements(array, arrLength, sum);
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
