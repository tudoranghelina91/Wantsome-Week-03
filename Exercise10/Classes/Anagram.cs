using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;

namespace Exercise10.Classes
{
    class Anagram
    {
        public static void PrintAnagramResult(bool isAnagram, string firstString, string secondString)
        {
            if (isAnagram)
            {
                OutputHandling.Message(firstString + " and " + secondString + " are anagrams!", ConsoleColor.Green);
            }

            else
            {
                OutputHandling.Message(firstString + " and " + secondString + " are not anagrams!", ConsoleColor.Red);
            }
        }

        public static bool FindAnagram(int[] freqArrayString1, int[] freqArrayString2)
        {
            if (freqArrayString1.Length != freqArrayString2.Length)
            {
                return false;
            }

            else
            {
                for (int i = 0; i < freqArrayString1.Length; i++)
                {
                    if (freqArrayString1[i] != freqArrayString2[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
