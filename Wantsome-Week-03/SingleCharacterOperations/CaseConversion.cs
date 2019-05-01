﻿namespace Wantsome_Week_03.SingleCharacterOperations
{
    public class CaseConversion
    {
        public static char ToUpperCase (char c)
        {
            const int UPPERCASE = -32;
            int cLower = c;
            if (c >= 97 && c <= 122)
            {
                cLower += UPPERCASE;
            }

            return (char)cLower;
        }

        public static char ToLowerCase(char c)
        {
            const int LOWERCASE = 32;
            int cUpper = c;
            if (c >= 65 && c <= 90)
            {
                cUpper += LOWERCASE;
            }

            return (char)cUpper;
        }
    }
}
