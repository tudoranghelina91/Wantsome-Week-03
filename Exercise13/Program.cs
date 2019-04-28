using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;
using Wantsome_Week_03.StringOperations;
using Wantsome_Week_03.ArrayOperations;

namespace Exercise13
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            // Take string as input
            OutputHandling.Message("Type in a string to check for duplicate characters: ", ConsoleColor.Green, false);
            string s = Console.ReadLine();

            // Remove extra spaces from string and tabs
            string sClean = StringManipulation.RemoveExtraSpaces(s);

            // Convert string to lower case
            //sClean = sClean.ToLower();

            // Convert String to char array
            char[] sToChar = Conversion.ConvertToCharArray(sClean);
            int sToCharLen = sToChar.Length;

            // Remove duplicate characters
            DuplicateRemoval.RemoveDuplicates(ref sToChar, ref sToCharLen);

            OutputHandling.PrintArray(sToChar, sToCharLen, "The string without duplicates is: ", "", newLine: false);
            OutputHandling.Question("Do you want to remove duplicate characters in another string? Y / N");
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
