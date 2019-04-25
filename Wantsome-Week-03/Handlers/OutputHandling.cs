using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wantsome_Week_03.Handlers
{
    public class OutputHandling
    {
        public static void Message(string message, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void Question(string askMessage, bool newLine = true)
        {
            if (newLine)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(askMessage);
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(askMessage);
                Console.ResetColor();
            }
        }

        public static void Error(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ResetColor();
        }

        public static void Question(int arrayIndex, string separator, string indexDefinition = "")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("{0} {1} {2} ", indexDefinition, arrayIndex, separator);
            Console.ResetColor();
        }

        public static void ExitMessage(string exitMessage)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(exitMessage);
            Console.ResetColor();
        }

        public static void PrintArrayLine(int[] arr, int arrLen, string resultMessage = "The array values are", string separator = "-")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(resultMessage);
            Console.ResetColor();
            for (int i = 0; i < arrLen; i++)
            {
                Console.WriteLine("[{0}] {1} {2}", i, separator, arr[i]);
            }
        }

        public static void PrintArray(int[] arr, int arrLen, string resultMessage, string separator = " ")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(resultMessage);
            Console.ResetColor();
            for (int i = 0; i < arrLen; i++)
            {
                if (i < arrLen - 1)
                    Console.Write("{0}{1}", arr[i], separator);

                else
                    Console.Write("{0}", arr[i]);
            }
        }
    }
}
