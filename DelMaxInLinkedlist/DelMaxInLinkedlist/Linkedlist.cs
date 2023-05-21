using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelMaxInLinkedlist
{
    class Linkedlist
    {
        public static Node head = null;

        public static int largestElement(Node head)
        {

            // Declare a max variable and initialize 
            // it with INT_MIN value. 
            // INT_MIN is integer type and its value 
            // is -32767 or less. 
            int max = int.MinValue;

            // Check loop while head not equal to NULL 
            while (head != null)
            {

                // If max is less then head->data then 
                // assign value of head->data to max 
                // otherwise node point to next node. 
                if (max < head.data)
                    max = head.data;
                head = head.next;
            }
            return max;
        }

        // Function that returns smallest element 
        // from the linked list. 
        public static int smallestElement(Node head)
        {

            // Declare a min variable and initialize 
            // it with INT_MAX value. 
            // INT_MAX is integer type and its value 
            // is 32767 or greater. 
            int min = int.MaxValue;

            // Check loop while head not equal to NULL 
            while (head != null)
            {

                // If min is greater then head->data then 
                // assign value of head->data to min 
                // otherwise node point to next node. 
                if (min > head.data)
                    min = head.data;

                head = head.next;
            }
            return min;
        }

        public static void push(int data)
        {
            // Allocate dynamic memory for newNode. 
            Node newNode = new Node();

            // Assign the data into newNode. 
            newNode.data = data;

            // newNode->next assign the address of 
            // head node. 
            newNode.next = (head);

            // newNode become the headNode. 
            (head) = newNode;
        }

        // Display linked list. 
        public static void printList(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + " -> ");
                head = head.next;
            }
            Console.WriteLine("NULL");
        }

        public static void deleteNode(int key)
        {
            // Store head node
            Node temp = head, prev = null;

            // If head node itself holds
            // the key to be deleted
            if (temp != null &&
                temp.data == key)
            {
                // Changed head
                head = temp.next;
                return;
            }
            // Unlink the node from linked list
            prev.next = temp.next;
        }
    }
}
