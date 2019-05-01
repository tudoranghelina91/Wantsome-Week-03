using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03;

namespace Exercise14.Classes
{
    public class ThirdFromEnd
    {
        public static int FindThirdFromEnd(SingleLinkedList singleLinkedList)
        {
            int thirdFromEnd = 0;
            SingleLinkedListNode singleLinkedListNode = singleLinkedList.head;

            while(singleLinkedListNode.next.next != null)
            {
                thirdFromEnd = singleLinkedListNode.nodeData;
                singleLinkedListNode = singleLinkedListNode.next;
            }

            return thirdFromEnd;
        }
    }
}
