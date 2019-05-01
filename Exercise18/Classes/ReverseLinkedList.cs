using System;
using System.Diagnostics;
using Wantsome_Week_03;
using Wantsome_Week_03.Handlers;

namespace Exercise18.Classes
{
    public class ReverseLinkedList
    {
        public static void PerformReversal(ref SingleLinkedList singleLinkedList, ref int singleLinkedListLength)
        {
            OutputHandling.Question("I - Iterative Approach, R - Recursive Approach");
            ConsoleKeyInfo cki = Console.ReadKey(true);

            if (cki.Key.Equals(ConsoleKey.I))
            {
                var watch = Stopwatch.StartNew();
                ReverseSingleLinkedListIterative(ref singleLinkedList);
                OutputHandling.Message("The reversed linked list is: ", ConsoleColor.Green);
                OutputHandling.PrintSingleLinkedList(singleLinkedList, singleLinkedListLength);
                watch.Stop();
                var elapsed = watch.Elapsed;
                OutputHandling.Message("Time elapsed for Iterative approach: " + elapsed.ToString());
            }

            else if (cki.Key.Equals(ConsoleKey.R))
            {
                var watch = Stopwatch.StartNew();
                ReverseSingleLinkedListRecursive(ref singleLinkedList.head);
                OutputHandling.Message("The reversed linked list is: ", ConsoleColor.Green);
                OutputHandling.PrintSingleLinkedList(singleLinkedList, singleLinkedListLength);
                watch.Stop();
                var elapsed = watch.Elapsed;
                OutputHandling.Message("Time elapsed for Recursive approach: " + elapsed.ToString());
            }

            else
            {
                PerformReversal(ref singleLinkedList, ref singleLinkedListLength);
            }
        }

        public static void ReverseSingleLinkedListIterative(ref SingleLinkedList singleLinkedList)
        {
            SingleLinkedListNode currentNode = singleLinkedList.head;
            SingleLinkedListNode nextNode = null;
            SingleLinkedListNode prevNode = null;

            while (currentNode != null)
            {
                nextNode = currentNode.next;
                currentNode.next = prevNode;
                prevNode = currentNode;
                currentNode = nextNode;
            }

            singleLinkedList.head = prevNode;
        }

        public static void ReverseSingleLinkedListRecursive(ref SingleLinkedListNode headNode)
        {
            SingleLinkedListNode firstNode = headNode;
            SingleLinkedListNode restNode = firstNode.next;

            if (headNode == null)
            {
                return;
            }

            if (restNode == null)
            {
                return;
            }

            ReverseSingleLinkedListRecursive(ref restNode);
            firstNode.next.next = firstNode;
            firstNode.next = null;
            headNode = restNode;
        }
    }
}
