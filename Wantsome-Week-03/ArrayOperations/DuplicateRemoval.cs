using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.SingleCharacterOperations;

namespace Wantsome_Week_03.ArrayOperations
{
    public class DuplicateRemoval
    {
        public static void RemoveDuplicates(ref int[] arr, ref int arrLen)
        {
            bool unique = true;
            do
            {
                unique = true;
                for (int i = 0; i < arrLen - 1; i++)
                {
                    for (int j = i + 1; j < arrLen; j++)
                    {
                        if ((arr[i] == arr[j] && (arr[i] != ' ' && arr[i] != '\n' && arr[i] != '\t')))
                        {
                            unique = false;
                            if (j < arrLen - 1)
                            {
                                for (int k = j + 1; k < arrLen; k++)
                                {
                                    arr[k - 1] = arr[k];
                                }
                            }
                            arrLen--;
                        }
                    }
                }
            } while (!unique);
        }

        public static void RemoveDuplicates(ref char[] arr, ref int arrLen)
        {
            bool unique = true;
            do
            {
                unique = true;
                for (int i = 0; i < arrLen - 1; i++)
                {
                    for (int j = i + 1; j < arrLen; j++)
                    {
                        if (CaseConversion.ToLowerCase(arr[i]) == CaseConversion.ToLowerCase(arr[j]) && (arr[i] != ' ' && arr[i] != '\n' && arr[i] != '\t'))
                        {
                            unique = false;
                            if (j < arrLen - 1)
                            { 
                                for (int k = j + 1; k < arrLen; k++)
                                {
                                    arr[k - 1] = arr[k];
                                }
                            }
                            arrLen--;
                        }
                    }
                }
            } while (!unique);
        }

    }
}
