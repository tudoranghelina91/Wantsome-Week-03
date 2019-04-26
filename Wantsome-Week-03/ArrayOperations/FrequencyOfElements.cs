using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wantsome_Week_03.ArrayOperations
{
    public class FrequencyOfElements
    {
        public static int[] GenerateFrequencyArray(int[] arr, int arrLen)
        {
            int freqArrayLength = MaxMinArray.Max(arr, arrLen) + 1;
            int[] freqArray = new int[freqArrayLength];

            for (int i = 0; i < arrLen; i++)
            {
                freqArray[arr[i]]++;
            }

            return freqArray;
        }
    }
}
