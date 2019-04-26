using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;
namespace Exercise4.Classes
{
    class DuplicatesInArray
    {
        public static bool HasDuplicates(int[] arr, int arrLen)
        {
            bool hasDuplicates = false;

            for (int i = 0; i < arrLen-1; i++)
            {
                for (int j = i + 1; j < arrLen; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        hasDuplicates = true;
                    }
                }
            }

            return hasDuplicates;
        }
    }
}
