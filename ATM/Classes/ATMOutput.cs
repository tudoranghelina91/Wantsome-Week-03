using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;

namespace ATM.Classes
{
    class ATMOutput
    {
        public static void MainMenuOutput(ref decimal balance, bool firstTime)
        {
            if (firstTime)
            {
                OutputHandling.Message("============================");
                OutputHandling.Message("= ", newLine: false);
                OutputHandling.Message("WELCOME TO WANTSOME BANK ", ConsoleColor.Cyan, false);
                OutputHandling.Message("=");
                OutputHandling.Message("============================");
                Console.WriteLine();
            }

            OutputHandling.Question("C - Check Balance");
            OutputHandling.Question("D - Deposit");
            OutputHandling.Question("W - Withdraw");
            OutputHandling.Question("E - Exit");

            ATMInput.MainMenuInput(ref balance);
        }
    }
}
