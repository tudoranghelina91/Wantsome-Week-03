using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear.Classes
{
    class Leap
    {
        public static bool IsLeap(int year)
        {
            if (year % 4 != 0)
                return false;

            else if (year % 100 != 0)
                return true;

            else if (year % 400 != 0)
                return false;

            return true;
        }
    }
}
