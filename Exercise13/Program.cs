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
            OutputHandling.Message("Type in a string to check for duplicate characters: ", ConsoleColor.Green, false);
            string s = Console.ReadLine();
            string sClean = StringManipulation.RemoveExtraSpaces(s);
            sClean = sClean.ToLower();
            char[] sToChar = Conversion.ConvertToCharArray(sClean);
            int sToCharLen = sToChar.Length;
            DuplicateRemoval.RemoveDuplicates(ref sToChar, ref sToCharLen);
            //OutputHandling.Message("The string without duplicates is: ", newLine: false);
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
