using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wantsome_Week_03.SingleLinkedListOperations
{
    public class Cycle
    {
        public static void CreateCycle(ref SingleLinkedList singleLinkedList, ref int singleLinkedListLength, int bindPoint)
        {
            SingleLinkedListNode node = singleLinkedList.head;

            // go to end of list
            while (node.next != null)
            {
                node = node.next;
            }

            SingleLinkedListNode bindingPointNode = singleLinkedList.head;

            for (int i = 0; i < bindPoint; i++)
            {
                bindingPointNode = bindingPointNode.next;
            }

            node.next = bindingPointNode;
            singleLinkedListLength++;
        }
    }
}
