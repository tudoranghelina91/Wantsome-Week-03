using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wantsome_Week_03
{
    public class SingleLinkedList
    {
        SingleLinkedListNode GetLastNode(SingleLinkedList singleLinkedList)
        {
            SingleLinkedListNode temp = singleLinkedList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void AddFirst(SingleLinkedList singleLinkedList, int new_data)
        {
            SingleLinkedListNode new_node = new SingleLinkedListNode(new_data);
            new_node.next = singleLinkedList.head;
            singleLinkedList.head = new_node;
        }

        public void AddLast(SingleLinkedList singleLinkedList, int new_data)
        {
            SingleLinkedListNode new_node = new SingleLinkedListNode(new_data);
            if (singleLinkedList.head == null)
            {
                singleLinkedList.head = new_node;
                return;
            }

            SingleLinkedListNode lastNode = GetLastNode(singleLinkedList);
            lastNode.next = new_node;
        }

        public void AddAfter(SingleLinkedListNode prev_node, int data)
        {
            if (prev_node == null)
            {
                return;         // previous node cannot be null handling
            }

            SingleLinkedListNode singleLinkedListNode = new SingleLinkedListNode(data);
            singleLinkedListNode.next = prev_node.next;
            prev_node.next = singleLinkedListNode;
        }

        public void Sort(SingleLinkedList singleLinkedList)
        {
            bool sorted = true;
            SingleLinkedListNode singleLinkedListNode = singleLinkedList.head;

            do
            {
                while (singleLinkedListNode != null)
                {
                    if (singleLinkedListNode.nodeData > singleLinkedListNode.next.nodeData)
                    {
                        sorted = false;

                        singleLinkedListNode.nodeData += singleLinkedListNode.next.nodeData;
                        singleLinkedListNode.next.nodeData = singleLinkedListNode.nodeData - singleLinkedListNode.next.nodeData;
                        singleLinkedListNode.nodeData -= singleLinkedListNode.next.nodeData;
                    }

                    singleLinkedListNode = singleLinkedListNode.next;
                }
            } while (!sorted);
        }

        public SingleLinkedListNode head;
    }
}
