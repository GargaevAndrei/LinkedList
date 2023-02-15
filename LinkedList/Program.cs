using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int val;
        public Node next;

        public Node(int val = 0)
        {
            this.val = val;
        }
        public Node(int val = 0, Node next = null)
        {
            this.val = val;
            this.next = next;
        }

        public void print()
        {
            Console.WriteLine("val = {0}", val);
        }
    }

    public class LinkedList
    {
        public Node head;
        public Node temp;
        public void printList()
        {
            while(head != null)
            {
                Console.WriteLine("val = {0}", head.val);
                head = head.next;
            }
            Console.WriteLine();
        }
        public void addNodeFront(Node n)
        {
            temp = head;
            while (temp != null)
                temp = temp.next;

            temp.next = n;
        }
        public void addNodeBack(Node n)
        {
            n.next = head;
            head = n;
        }

        public void addNodePosition(Node n, int pos)
        {
            temp = head;
            for (int i = 0; i < pos; i++)
            {
                if (temp.next != null)
                    temp = temp.next;
            }
            n.next = temp.next;
            temp.next = n;
        }
    }

    class Program
    {
        //static void printList(Node n)
        //{
        //    while (n.next != null)
        //    {
        //        Console.WriteLine("val = {0}", n.val);
        //        n = n.next;
        //    }
        //    Console.WriteLine("val = {0}", n.val);
        //}

        static void Main(string[] args)
        {
            Node n1 = new Node(3, null);       
            Node n2 = new Node(4, n1);
            Node n3 = new Node(2, n2);

            LinkedList l = new LinkedList();

            l.head = n3;
            l.printList();

            l.addNodeBack(new Node(5));
            l.addNodeFront(new Node(7));
            l.printList();

            Console.ReadKey();
        }

        
    }
}
