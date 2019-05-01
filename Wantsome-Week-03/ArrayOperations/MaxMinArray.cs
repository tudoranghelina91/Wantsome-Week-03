namespace Wantsome_Week_03.ArrayOperations
{
    public class MaxMinArray
    {
        public static int Min(int[] arr, int arrLen)
        {
            int min = arr[0];

            for (int i = 1; i < arrLen; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        public static int MinIndex(int[] arr, int arrLen)
        {
            int min = arr[0];
            int minIndex = 0;

            for (int i = 1; i < arrLen; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public static int Max(int[] arr, int arrLen)
        {
            int max = arr[0];

            for (int i = 1; i < arrLen; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        public static int MaxIndex(int[] arr, int arrLen)
        {
            int max = arr[0];
            int maxIndex = 0;

            for (int i = 1; i < arrLen; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}
