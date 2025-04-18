using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int value)
        {
            data = value;
            next = null;
        }
    }
    class LinkedList
    {
        public Node head;
        public void Insert(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;

            while (current.next != null)
            {
                current = current.next;
               
            }
            current.next = newNode;

        }
        public bool Contains(int key)
        {
            Node current = head;
            while (current != null)
            {
                if (current.data == key)
                    return true;
                current = current.next;
            }
            return false;
        }
    
        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + (current.next != null ? " -> " : ""));
                current = current.next;
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main()
        {
            LinkedList list1 = new LinkedList();
            list1.Insert(14);
            list1.Insert(21);
            list1.Insert(11);
            list1.Insert(30);
            list1.Insert(10);
            Console.Write("List 1: ");
            list1.Print();
            Console.WriteLine(list1.Contains(14) ? "Output: Yes" : "Output: No"); // Yes

            LinkedList list2 = new LinkedList();
            list2.Insert(6);
            list2.Insert(21);
            list2.Insert(17);
            list2.Insert(30);
            list2.Insert(10);
            list2.Insert(8);
            Console.Write("List 2: ");
            list2.Print();
            Console.WriteLine(list2.Contains(13) ? "Output: Yes" : "Output: No"); // No

            LinkedList list3 = new LinkedList();
            list3.Insert(9);
            list3.Insert(18);
            list3.Insert(27);
            list3.Insert(36);
            list3.Insert(45);
            Console.Write("List 3: ");
            list3.Print();
            Console.WriteLine(list3.Contains(27) ? "Output: Yes" : "Output: No"); // Yes
        }
    }

}
