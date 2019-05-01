using System;
using Wantsome_Week_03.Handlers;
using Wantsome_Week_03.StringOperations;
using Exercise10.Classes;

namespace Exercise10
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            OutputHandling.Question("First String: ", false);
            string firstString = Console.ReadLine();
            int[] firstStringFreqArray = FrequencyOfElements.GenerateFrequencyArray(firstString, firstString.Length);

            OutputHandling.Question("Second String: ", false);
            string secondString = Console.ReadLine();
            int[] secondStringFreqArray = FrequencyOfElements.GenerateFrequencyArray(secondString, secondString.Length);

            bool isAnagram = Anagram.FindAnagram(firstStringFreqArray, secondStringFreqArray);
            Anagram.PrintAnagramResult(isAnagram, firstString, secondString);

            OutputHandling.Question("Do you want to check other two strings for anagram?");
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
