using System;
using Wantsome_Week_03;
using Wantsome_Week_03.Handlers;
using Wantsome_Week_03.SingleLinkedListOperations;

namespace Exercise8
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            // length of single linked list
            int listLength = InputHandling.ReadValue("Length of linked list: ");

            // create single linked list
            SingleLinkedList myList = new SingleLinkedList();

            // read values into linked list
            for (int i = 0; i < listLength; i++)
            {
                myList.AddLast(myList, InputHandling.ReadValue(""));
            }

            // create cycle
            Cycle.CreateCycle(ref myList, ref listLength, 3);
            
            OutputHandling.PrintSingleLinkedList(myList, listLength);

            programRunning = InputHandling.QuestionOptions();
        }

        static void Main(string[] args)
        {
            bool programRunning = true;
            while (programRunning)
            {
                RunProgram(ref programRunning);
            }
        }
    }
}
