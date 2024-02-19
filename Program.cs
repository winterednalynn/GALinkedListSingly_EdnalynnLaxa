using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GALinkedListSingly_EdnalynnLaxa
{
    //EDNA LYNN LAXA 
    //COMPUTER PROGRAMMING V 
    //ASSIGNMENT: LINKED LIST SINGLY 
    //FEBRUARY 18, 2024 

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a linked list of strings
            LinkedList<string> myList = new LinkedList<string>();


            // Add elements to the linked list
            myList.Add("first"); //ADDING TO LIST 
            myList.Add("second");
            myList.Add("third");


            // Remove an element
            myList.Add("second"); // REMOVE THAT LIST 

            // Test the Display method to print the elements
            Console.WriteLine("Linked List Elements:");
            myList.Display();

            int index = 1;
            Console.WriteLine($"The element at index {index} is {myList[index]}");

            Console.WriteLine(); // SPACING
            Console.WriteLine();

            Console.WriteLine("Insert Blah into Index 2");
            //Insert into Index 
            myList.InsertAtIndex("Blah", 2);
            myList.Display();

            Console.WriteLine();// SPACING 
            Console.WriteLine();

            Console.WriteLine("Removing Blah to the list , cause it dont belong");
            myList.RemoveAt(2);
            myList.Display();
            Console.WriteLine("Blah is no longer present on ths list");

            Console.WriteLine(); // Spacing 
            Console.WriteLine();

            Console.WriteLine("*********** CLEARING THE LIST*************");
            myList.Clear();
            myList.Display(); // Prints Null 



        }

        //The members of a singly linked list are not kept in consecutive memory regions, making it a linear data structure.
        //Rather, every component, known as a node, is composed of two parts:

        //Data: An integer, a string, or any other data type can be stored in this field to represent the actual information that
        //the node contains.
        //This pointer builds a structure like a chain by referencing the subsequent node in the sequence.
        //The pointer of the final node usually leads to null, signifying the list's end.

        //singly linked lists only permit one way traversal.
        //You cannot travel directly back from one node to the previous one; instead, you must start at the head(the first node)
        //and follow the successive pointers to access subsequent nodes.

        //EXAMPLE FROM BRO CODE: 
        //To help envision a singly linked list, consider the following analogy: Consider a couple of rail cars.
        //Every vehicle has data (i.e., passengers or freight), and it is linked to the following vehicle by a hook
        //(i.e., the next pointer). The train is passable from the head(front) to the tail(rear), but not the other way around



    }
}
