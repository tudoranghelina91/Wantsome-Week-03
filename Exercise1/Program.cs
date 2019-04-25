using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;

namespace Exercise1
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            int arrLength = InputHandling.ReadArrayLength();
            int[] array = new int[arrLength];
            int index = 0;
            InputHandling.ReadArrayElements(ref array, arrLength, ref index);
            Console.WriteLine("The sum of the even array elements is: {0}", Sum(array, arrLength));
            OutputHandling.Question("Do you want to print the sum of other even numbers in an array? Y / N");
            programRunning = InputHandling.QuestionOptions();
        }

        static int Sum(int[] arr, int arrLength)
        {
            int s = 0;

            for (int i = 0; i < arrLength; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    s += arr[i];
                }
            }

            return s;
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
