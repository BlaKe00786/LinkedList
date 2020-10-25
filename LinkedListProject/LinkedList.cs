using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProject
{
    public class LinkedList
    {
        internal Node<int> head;
        public void Add(int data)
        {
            Node<int> node = new Node<int>(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node<int> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
            sortAsc();
        }
        public void Display()
        {
            Node<int> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public Node<int> InsertAtParticularPosition(int position, int data)
        {
            Node<int> temp = head;
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node<int>(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node<int> node = new Node<int>(data);
                        node.next = temp.next;
                        temp.next = node;
                        break;
                    }
                    temp = temp.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }
        public Node<int> pop()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }
        public Node<int> popLast()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node<int> newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
        public int Search(int value)
        {
            int position = 1;
            Node<int> temp = head;
            while (temp != null)
            {
                position = position + 1;
                if (temp.data == value)
                {
                    return position;
                }
                temp = temp.next;
            }
            return -1;
        }
        public void DeleteNode(int key)
        {
            Node<int> temp = head, previous = null;
            if (temp != null &&
                temp.data == key)
            {
                head = temp.next;
                return;
            }
            while (temp != null &&
                   temp.data != key)
            {
                previous = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            previous.next = temp.next;
        }
        public int size()
        {
            int size = 0;
            Node<int> temp = head;
            while (temp != null)
            {
                size = size + 1;
                temp = temp.next;
            }
            return size;
        }
        public void sortAsc()
        {
            Node<int> temp = head;
            Node<int> firstval = null;
            int val = 0;
            while (temp != null)
            {
                firstval = temp.next;
                while (firstval != null)
                {
                    if (temp.data > firstval.data)
                    {
                        val = firstval.data;
                        firstval.data = temp.data;
                        temp.data = val;
                    }
                    firstval = firstval.next;
                }
                temp = temp.next;
            }
        }
    }
}

