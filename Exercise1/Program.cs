﻿using System;
using Wantsome_Week_03.Handlers;

namespace Exercise1
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            int arrLength = InputHandling.ReadCollectionLength();
            int[] array = new int[arrLength];
            int index = 0;
            InputHandling.ReadCollectionElements(ref array, arrLength, ref index);
            Console.WriteLine("The sum of the even array elements is: {0}", CalculateSum.Sum(array, arrLength));
            OutputHandling.Question("Do you want to print the sum of other even numbers in an array? Y / N");
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
