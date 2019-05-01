using Wantsome_Week_03.ArrayOperations;

namespace Wantsome_Week_03.NumericOperation
{
    public class BaseConversion
    {
        public static int[] ConvertBase10ToBaseX(int base10, int baseX)
        {
            int[] baseXNumberReversed = new int[32];
            int baseXNumberReversedLength = 0;

            while (base10 > 0)
            {
                baseXNumberReversed[baseXNumberReversedLength++] = base10 % baseX;
                base10 /= baseX;
            }

            ArrayManipulation.ReverseArray(ref baseXNumberReversed, baseXNumberReversedLength);

            int[] baseXNumber = new int[baseXNumberReversedLength];

            for (int i = 0; i < baseXNumberReversedLength; i++)
            {
                baseXNumber[baseXNumberReversedLength - 1 - i] = baseXNumberReversed[i];
            }

            return baseXNumber;
        }
    }
}
