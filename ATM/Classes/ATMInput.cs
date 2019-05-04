using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;
using ATM.Classes;

namespace ATM.Classes
{
    public class ATMInput
    {
        public static void MainMenuInput(ref decimal balance)
        {
            Console.WriteLine();
            ConsoleKeyInfo cki = Console.ReadKey(true);

            if (cki.Key.Equals(ConsoleKey.C))
            {
                Operations.CheckBalance(balance);
                ATMOutput.MainMenuOutput(ref balance, false);
            }

            else if (cki.Key.Equals(ConsoleKey.D))
            {
                decimal amount = InputHandling.ReadValueD("Amount to deposit: ");
                Operations.Deposit(amount, ref balance);
                ATMOutput.MainMenuOutput(ref balance, false);
            }

            else if (cki.Key.Equals(ConsoleKey.W))
            {
                decimal amount = InputHandling.ReadValueD("Amount to withdraw: ");
                Operations.Withdraw(amount, ref balance);
                ATMOutput.MainMenuOutput(ref balance, false);
            }

            else if (cki.Key.Equals(ConsoleKey.E))
            {
                ProgramFlowHandling.Exit("Thank you for choosing WANTSOME BANK! Retrieve your card from the ATM Machine");
            }

            else
            {
                ATMInput.MainMenuInput(ref balance);
            }
        }
    }
}
