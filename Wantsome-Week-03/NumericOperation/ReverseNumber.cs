namespace Wantsome_Week_03.NumericOperation
{
    public class ReverseNumber
    {
        public static int Reverse(int n)
        {
            int nRev = 0;

            while (n != 0)
            {
                nRev = nRev * 10 + n % 10;
                n /= 10;
            }

            return nRev;
        }
    }
}
