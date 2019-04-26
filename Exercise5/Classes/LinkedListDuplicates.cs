using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;

namespace Exercise5.Classes
{
    class LinkedListDuplicates
    {
        public static void DisplayLinkedList(LinkedList<int> linkedList)
        {
            int i = 1;
            OutputHandling.Message("The values in the sorted linked list after the duplicates removal are: ", ConsoleColor.Green);

            foreach(var node in linkedList)
            {
                OutputHandling.Message("Element " + i++ + ": " + node);
            }
        }

        public static void RemoveLinkedListDuplicates(ref LinkedList<int> linkedList)
        {
            LinkedListNode<int> firstNode = linkedList.First;

            while (firstNode != null)
            {
                while (firstNode.Next != null && firstNode.Value == firstNode.Next.Value)
                {
                    linkedList.Remove(firstNode.Next);
                }
                firstNode = firstNode.Next;
            }
        }
    }
}
