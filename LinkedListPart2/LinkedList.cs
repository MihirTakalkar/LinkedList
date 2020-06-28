using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace LinkedListPart2
{
    class LinkedList<T>
    {
        public Node<T> head;
        public Node<T> tail;
        public int count;

        public LinkedList()
        {
            this.count = 0;
        }

        public void AddFirst(T value)
        {
            if(head == null)
            {
                head = new Node<T>(value);
            }

            else
            {
                T temp = head.value;
                head = new Node<T>(value);
                head.next = new Node<T>(temp);
            }
        }

        public void AddLast(T value)
        {
            if(head == null)
            {
                head = new Node<T>(value);
            }

            else
            {
                T temp = tail.value;
                tail = new Node<T>(value);
                tail.next = new Node<T>(temp);
            }
        }

        public void AddBefore(Node<T> given, T value)
        {
            var currentNode = head;
            while ((currentNode.next != null))
            {
                if(currentNode.next == given)
                {
                    Node<T> newnode = new Node<T>(value);
                    newnode.next = given;
                    currentNode.next = newnode;
                }

                else
                {
                    currentNode = currentNode.next; 
                }
                
            }
        }

        public void AddAfter(Node<T> given, T value)
        {
            var currentNode = head;
            while(currentNode.next != null)
            {
                if(currentNode == given)
                {
                    Node<T> newnode = new Node<T>(value);
                    newnode.next = currentNode.next;
                    currentNode.next = newnode;
                }

                else
                {
                    currentNode = currentNode.next;
                }
            }
        }

        public bool RemoveFirst() 
        {
            if(head.value == null)
            {
                return false;
            }

            else
            {
                head = head.next;
            }
            return true;
        }

        public bool RemoveLast()
        {

        }

        public bool Contains(T val)
        {
            Node<T> current = head;
            for (int i = 0; i < count; i++, current = current.next)
            {
                if(val.Equals(current.value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
