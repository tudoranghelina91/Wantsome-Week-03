
using Wantsome_Week_03.Handlers;
using Wantsome_Week_03;

using Exercise18.Classes;

namespace Exercise18
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            int linkedListLength = InputHandling.ReadCollectionLength("Length of Linked List: ");
            SingleLinkedList singleLinkedList = new SingleLinkedList();
            int failIndex = 0;
            InputHandling.ReadCollectionElements(ref singleLinkedList, linkedListLength, ref failIndex);
            ReverseLinkedList.PerformReversal(ref singleLinkedList, ref linkedListLength);
            OutputHandling.Question("Do you want to reverse another Linked List? Y / N");
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
