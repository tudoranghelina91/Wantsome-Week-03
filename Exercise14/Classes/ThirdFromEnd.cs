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
