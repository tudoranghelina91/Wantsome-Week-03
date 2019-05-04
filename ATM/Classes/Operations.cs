using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;
using ATM.Classes;

namespace ATM.Classes
{
    class Operations
    {
        public static void Deposit(decimal amount, ref decimal balance)
        {
            balance += amount;
            OutputHandling.Message("Deposited sum: " + amount);
            CheckBalance(balance);
        }

        public static void Withdraw(decimal amount, ref decimal balance)
        {
            if (Validation.ValidateWithdrawal(amount, balance))
            {
                balance -= amount;
                OutputHandling.Message("Withdrawn Amount: " + amount);
                CheckBalance(balance);
            }

            else
            {
                OutputHandling.Error("Insufficient funds!");
                CheckBalance(balance);
                OutputHandling.Message("You tried to withdraw: " + amount);
            }
        }

        public static void CheckBalance(decimal balance)
        {
            OutputHandling.Message("Account balance: " + balance);
        }
    }
}
