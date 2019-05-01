using Wantsome_Week_03.SingleCharacterOperations;

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

        public static int[] CopyArray(int[] arr, int endIndex, int startIndex = 0)
        {
            int[] arrCopy = new int[endIndex - startIndex];
            int arrCopyI = 0;

            for (int i = startIndex; i < endIndex; i++)
            {
                arrCopy[arrCopyI++] = arr[i];
            }

            return arrCopy;
        }

        public static int[] RotateArray(int[] arr, int arrLen, int pivot)
        {
            int[] arrRotated = new int[arrLen];
            int arrRotatedLen = 0;

            for (int i = pivot; i < arrLen; i++)
            {
                arrRotated[arrRotatedLen++] = arr[i];
            }

            for (int i = 0; i < pivot; i++)
            {
                arrRotated[arrRotatedLen++] = arr[i];
            }

            return arrRotated;
        }

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
