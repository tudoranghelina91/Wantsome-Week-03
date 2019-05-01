namespace Wantsome_Week_03.ArrayOperations
{
    public class Sorting
    {
        public static void SelectSort(ref int[] arr, int arrLen)
        {
            for (int i = 0; i < arrLen - 1; i++)
            {
                for (int j = i + 1; j < arrLen; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        arr[i] += arr[j];
                        arr[j] = arr[i] - arr[j];
                        arr[i] -= arr[j];
                    }
                }
            }
        }

        public static void BubbleSort(ref int[] arr, int arrLen)
        {
            bool sorted = true;

            do
            {
                sorted = true;
                for (int i = 0; i < arrLen - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        sorted = false;
                        arr[i] += arr[i + 1];
                        arr[i + 1] = arr[i] - arr[i + 1];
                        arr[i] -= arr[i + 1];
                    }
                }
            } while (!sorted);
        }
    }
}
