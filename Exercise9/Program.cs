using System;
using System.Collections.Generic;
using Wantsome_Week_03.Handlers;
using Wantsome_Week_03.LinkedListsOperations;
using Exercise9.Classes;

namespace Exercise9
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            // define two linked list objects
            LinkedList<int> list1 = new LinkedList<int>();
            LinkedList<int> list2 = new LinkedList<int>();

            int failIndex = 0;
            int list1Length = InputHandling.ReadCollectionLength("List 1 length: ");
            InputHandling.ReadCollectionElements(ref list1, list1Length, ref failIndex);

            failIndex = 0;
            int list2Length = InputHandling.ReadCollectionLength("List 2 length: ");
            InputHandling.ReadCollectionElements(ref list2, list2Length, ref failIndex);

            Sorting.BubbleSort(ref list1);
            Sorting.BubbleSort(ref list2);
            LinkedList<int> mergedList = Merge.MergeLinkedList(list1, list2);
            Sorting.BubbleSort(ref mergedList);

            OutputHandling.Message("First List: ", ConsoleColor.Yellow, false);
            OutputHandling.PrintLinkedList(list1);
            OutputHandling.Message("Second List: ", ConsoleColor.Yellow, false);
            OutputHandling.PrintLinkedList(list2);
            OutputHandling.Message("Merged Lists: ", ConsoleColor.Yellow, false);
            OutputHandling.PrintLinkedList(mergedList);

            OutputHandling.Question("Do you want to merge other two Linked Lists? Y / N");
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
