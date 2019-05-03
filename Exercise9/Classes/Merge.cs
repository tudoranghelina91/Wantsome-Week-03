using System.Collections.Generic;

namespace Exercise9.Classes
{
    public class Merge
    {
        public static LinkedList<int> MergeLinkedList(LinkedList<int> firstLinkedList, LinkedList<int> secondLinkedList)
        {
            LinkedListNode<int> firstLinkedListNode = firstLinkedList.First;
            LinkedListNode<int> secondLinkedListNode = secondLinkedList.First;
            LinkedList<int> mergedLinkedList = new LinkedList<int>();
            LinkedListNode<int> mergedLinkedListNode = mergedLinkedList.First;

            while (firstLinkedListNode != null && secondLinkedListNode != null)
            {

                if (firstLinkedListNode.Value < secondLinkedListNode.Value)
                {
                    mergedLinkedList.AddLast(firstLinkedListNode.Value);
                    firstLinkedListNode = firstLinkedListNode.Next;
                }

                else if (secondLinkedListNode.Value < firstLinkedListNode.Value)
                {
                    mergedLinkedList.AddLast(secondLinkedListNode.Value);
                    secondLinkedListNode = secondLinkedListNode.Next;
                }

                else
                {
                    mergedLinkedList.AddLast(firstLinkedListNode.Value);
                    firstLinkedListNode = firstLinkedListNode.Next;

                    mergedLinkedList.AddLast(secondLinkedListNode.Value);
                    secondLinkedListNode = secondLinkedListNode.Next;
                }

            }

            while (firstLinkedListNode != null)
            {
                mergedLinkedList.AddLast(firstLinkedListNode.Value);
                firstLinkedListNode = firstLinkedListNode.Next;
            }

            while (secondLinkedListNode != null)
            {
                mergedLinkedList.AddLast(secondLinkedListNode.Value);
                secondLinkedListNode = secondLinkedListNode.Next;
            }

            return mergedLinkedList;                        
        }
    }
}
