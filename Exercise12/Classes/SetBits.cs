using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.NumericOperation;

namespace Exercise12.Classes
{
    class SetBits
    {
        public static int CountSetBits(int n)
        {
            int numberOfSetBits = 0;
            int[] base2Array = BaseConversion.ConvertBase10ToBaseX(n, 2);
            for (int i = 0; i < base2Array.Length; i++)
            {
                if (base2Array[i] == 1)
                {
                    numberOfSetBits++;
                }
            }

            return numberOfSetBits;
        }
    }
}
