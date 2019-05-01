using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03;

namespace Exercise8.Classes
{
    class DetectCycles
    {
        public static bool CycleExists(SingleLinkedList singleLinkedList)
        {
            // Determine if there is a cycle
            SingleLinkedListNode slowNode = singleLinkedList.head;
            SingleLinkedListNode fastNode = singleLinkedList.head.next;

            while (fastNode != null && fastNode.next != null & slowNode != null)
            {
                if (slowNode == fastNode)
                {
                    return true;
                }

                slowNode = slowNode.next;
                fastNode = fastNode.next.next;
            }
            return false;
        }
    }
}
