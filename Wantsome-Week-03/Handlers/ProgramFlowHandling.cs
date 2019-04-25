using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wantsome_Week_03.Handlers
{
    public class ProgramFlowHandling
    {
        public static void Exit(string exitMessage)
        {
            OutputHandling.ExitMessage(exitMessage);
            Console.ReadKey();
        }
    }
}
