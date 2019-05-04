using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Classes
{
    class Validation
    {
        public static bool ValidateWithdrawal(decimal amount, decimal balance)
        {
            if (amount > balance)
                return false;

            return true;
        }
    }
}
