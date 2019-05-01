using System;

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
