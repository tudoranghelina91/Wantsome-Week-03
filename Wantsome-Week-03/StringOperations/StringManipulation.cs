using System;

namespace Wantsome_Week_03.StringOperations
{
    public class StringManipulation
    {
        public static string RemoveExtraSpaces(string s)
        {
            char[] separators = new char[] { ' ', '\t', '\n' };
            //string[] words = new string[s.Length];
            string[] words = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string sClean = "";

            int wordIndex = 0;
            foreach (string word in words)
            {
                if (wordIndex > 0 && wordIndex < words.Length)
                {
                    sClean = String.Concat(sClean, " ");
                }

                sClean = String.Concat(sClean, word);

                wordIndex++;
            }

            return sClean;
        }
    }
}
