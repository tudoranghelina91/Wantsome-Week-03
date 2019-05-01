using System;
using Wantsome_Week_03;
using Wantsome_Week_03.Handlers;
using Exercise14.Classes;

namespace Exercise14
{
    class Program
    {
        static void RunProgram(ref bool programRunning)
        {
            int myListLength = InputHandling.ReadCollectionLength("Singly Linked List Length: ");
            SingleLinkedList myList = new SingleLinkedList();
            int failIndex = 0;
            InputHandling.ReadCollectionElements(ref myList, myListLength, ref failIndex);
            int thirdFromEnd = ThirdFromEnd.FindThirdFromEnd(myList);

            OutputHandling.Message("The third element counting from the end is: " + thirdFromEnd, ConsoleColor.Green);
            OutputHandling.Question("Do you want to find another third last element of a linked list? Y / N");
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
