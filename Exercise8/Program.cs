using System;
using Wantsome_Week_03;
using Wantsome_Week_03.Handlers;
using Wantsome_Week_03.SingleLinkedListOperations;
using Exercise8.Classes;

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

            // create cycle
            OutputHandling.Question("Do you want to add a cycle to the linked list?  Y / N");
            bool AddCycles = InputHandling.QuestionOptions(false);

            if (AddCycles)
            {
                int bindPoint = InputHandling.ReadCollectionIndex(listLength, "Point to form a cycle to: ");
                Cycle.CreateCycle(ref myList, ref listLength, bindPoint);
            }

            // cycle exists?

            bool hasCycles = DetectCycles.CycleExists(myList);

            if (hasCycles)
            {
                OutputHandling.Message("The Single Linked List has a cycle", ConsoleColor.Green);
            }

            else
            {
                OutputHandling.Message("The Single Linked List does not contain cycles", ConsoleColor.DarkMagenta);
            }

            OutputHandling.PrintSingleLinkedList(myList, listLength);
            OutputHandling.Question("Do you want to detect cycles in another linked list?");
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
