using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wantsome_Week_03.StringOperations
{
    public class FrequencyOfElements
    {
        public static int[] GenerateFrequencyArray(string inputString, int strLength)
        {
            inputString = inputString.ToLower();
            int[] freqArray = new int[128];

            for (int i = 0; i < strLength; i++)
            {
                freqArray[(int)inputString[i]]++;
            }

            return freqArray;
        }
    }
}
