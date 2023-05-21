using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelMaxInLinkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start with empty list 
            // head = new Node(); 

            // Using push() function to construct 
            // singly linked list 
            // 17->22->13->14->15 
            Linkedlist.push(15);
            Linkedlist.push(14);
            Linkedlist.push(13);
            Linkedlist.push(22);
            Linkedlist.push(17);
            Console.WriteLine("Linked list is : ");

            // Call printList() function to 
            // display the linked list. 
            Linkedlist.printList(Linkedlist.head);
            Console.Write("Maximum element in linked list: ");

            // Call largestElement() function to get 
            // largest element in linked list. 
            int MX = Linkedlist.largestElement(Linkedlist.head);
            Console.WriteLine(MX);
            Console.Write("Minimum element in linked list: ");

            // Call smallestElement() function to get 
            // smallest element in linked list. 
            Console.Write(Linkedlist.smallestElement(Linkedlist.head));
            Console.WriteLine(".....");
            Linkedlist.deleteNode(MX);
            Console.WriteLine("Linked list is : ");
            Linkedlist.printList(Linkedlist.head);

            Console.ReadKey();
        }
    }
}
