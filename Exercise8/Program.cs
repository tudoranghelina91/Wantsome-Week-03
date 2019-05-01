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
            int listLength = InputHandling.ReadCollectionLength("Length of linked list: ");
            SingleLinkedList myList = new SingleLinkedList();

            int lastFailIndex = 0;
            InputHandling.ReadCollectionElements(ref myList, listLength, ref lastFailIndex);

            int bindPoint = InputHandling.ReadCollectionIndex(listLength, "Point to form a cycle to: ");

            // create cycle
            Cycle.CreateCycle(ref myList, ref listLength, bindPoint);
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
