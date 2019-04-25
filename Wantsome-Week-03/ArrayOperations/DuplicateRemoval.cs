using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wantsome_Week_03.ArrayOperations
{
    public class DuplicateRemoval
    {
        public static void RemoveDuplicates(ref int[] arr, ref int arrLen)
        {
            for (int i = 0; i < arrLen - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    for (int j = i + 1; j < arrLen; j++)
                    {
                        arr[i] = arr[j];
                    }
                    arrLen--;
                }
            }
        }
    }
}
