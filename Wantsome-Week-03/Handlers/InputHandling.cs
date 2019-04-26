using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;

namespace Wantsome_Week_03.Handlers
{
    public class InputHandling
    {
        public static bool QuestionOptions()
        {
            bool programRunning = true;
            ConsoleKeyInfo menuOption = Console.ReadKey(true);

            if (menuOption.Key.Equals(ConsoleKey.Y))
            {
                programRunning = true;
            }

            else if (menuOption.Key.Equals(ConsoleKey.N))
            {
                ProgramFlowHandling.Exit("Program will now exit. Press any key...");
                programRunning = false;
            }

            else
            {
                return QuestionOptions();
            }

            return programRunning;
        }

        public static int ReadArrayLength(string messagePrefix = "Array Length: ")
        {
            try
            {
                OutputHandling.Question(messagePrefix, false);
                int arrayLength = Convert.ToInt32(Console.ReadLine());
                return arrayLength;
            }

            catch
            {
                OutputHandling.Error("Invalid input value! Please use an integer");
                return ReadArrayLength(messagePrefix);
            }
        }

        public static void ReadArrayElements(ref int[] array, int arrLen, ref int index)
        {
            for (int i = index; i < arrLen; i++)
            {
                try
                {
                    OutputHandling.Question(i, "-", "Element");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                catch
                {
                    OutputHandling.Error("Invalid input value! Please use an integer");
                    index = i--;
                }
            }
        }

        public static int ReadValue(string message)
        {
            try
            {
                OutputHandling.Question(message, false);
                int x = Convert.ToInt32(Console.ReadLine());
                return x;
            }

            catch
            {
                OutputHandling.Error("Invalid input value! Must be an integer!");
                return ReadValue(message);
            }
        }

        public static void ReadLinkedListElements(ref LinkedList<int> linkedList, int linkedListLength, ref int index)
        {
          
                for (int i = 0; i < linkedListLength; i++)
                {
                    try
                    {
                        OutputHandling.Question("Element " + i + ": ", false);
                        linkedList.AddFirst(Convert.ToInt32(Console.ReadLine()));
                    }

                    catch
                    {
                        OutputHandling.Error("Invalid input value! Please use an integer");
                        index = i--;
                    }
                }
        }
    }
}
