using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wantsome_Week_03.ArrayOperations
{
    public class ArrayManipulation
    {
        public static void ReverseArray(ref int[] arr, int arrLen)
        {
            for (int i = 0; i < arrLen / 2; i++)
            {
                arr[i] += arr[arrLen - 1 - i];
                arr[arrLen - 1 - i] = arr[i] - arr[arrLen - 1 - i];
                arr[i] -= arr[arrLen - 1 - i];
            }
        }
    }
}
