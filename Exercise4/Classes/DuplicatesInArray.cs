namespace Exercise4.Classes
{
    class DuplicatesInArray
    {
        public static bool HasDuplicates(int[] arr, int arrLen)
        {
            for (int i = 0; i < arrLen-1; i++)
            {
                for (int j = i + 1; j < arrLen; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
