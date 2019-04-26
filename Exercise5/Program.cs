using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_03.Handlers;
using Exercise5.Classes;

namespace Exercise5
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {

            int linkedListLength = InputHandling.ReadValue("Sorted Linked List Length: ");
            LinkedList<int> linkedList = new LinkedList<int>();
            int index = 0;
            InputHandling.ReadLinkedListElements(ref linkedList, linkedListLength, ref index);
            LinkedListDuplicates.RemoveLinkedListDuplicates(ref linkedList);
            LinkedListDuplicates.DisplayLinkedList(linkedList);
            OutputHandling.Question("Do you want to remove duplicates from another sorted Linked List? Y / N");
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
