using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;
using ATM.Classes;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 0;
            ATMOutput.MainMenuOutput(ref balance, true);
        }
    }
}
