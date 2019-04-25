using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;
namespace Exercise4.Classes
{
    class CommonElementsInArray
    {
        public static void PrintCommonElements(int[] arr1, int arr1Len, int[] arr2, int arr2Len)
        {
            Console.Write("Common elements are: ");
            for (int i = 0; i < arr1Len; i++)
            {
                for (int j = 0; j < arr2Len; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.Write(arr1[i] + " ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
