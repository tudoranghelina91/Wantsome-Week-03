using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wantsome_Week_03.LinkedListsOperations
{
    public class Sorting
    {
        public static void BubbleSort(ref LinkedList<int> linkedList)
        {
            bool sorted = true;

            LinkedListNode<int> linkedListNode = linkedList.First;

            do
            {
                sorted = true;
                linkedListNode = linkedList.First;
                while (linkedListNode.Next != null)
                {
                    if (linkedListNode.Value > linkedListNode.Next.Value)
                    {
                        sorted = false;
                        linkedListNode.Value += linkedListNode.Next.Value;
                        linkedListNode.Next.Value = linkedListNode.Value - linkedListNode.Next.Value;
                        linkedListNode.Value -= linkedListNode.Next.Value;
                    }
                    linkedListNode = linkedListNode.Next;
                }
            } while (!sorted);
        }
    }
}
