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
        static string lesserThanEqualZeroError = "Amount can't be lesser than or equal to 0";

        public static void Deposit(decimal amount, ref decimal balance)
        {
            if (amount > 0)
            {
                balance += amount;
                OutputHandling.Message("Deposited sum: " + amount);
                CheckBalance(balance);
            }

            else
            {
                OutputHandling.Error(lesserThanEqualZeroError);
                ATMInput.Deposit(ref balance);
            }
        }

        public static void Withdraw(decimal amount, ref decimal balance)
        {
            if (amount >= 0)
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

            else
            {
                OutputHandling.Error(lesserThanEqualZeroError);
                ATMInput.Withdraw(ref balance);
            }
        }

        public static void CheckBalance(decimal balance)
        {
            OutputHandling.Message("Account balance: " + balance);
            ATMOutput.MainMenuOutput(ref balance, false);
        }
    }
}
