namespace Exercise1
{
    class CalculateSum
    {
        public static int Sum(int[] arr, int arrLength)
        {
            int s = 0;

            for (int i = 0; i < arrLength; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    s += arr[i];
                }
            }

            return s;
        }
    }
}
