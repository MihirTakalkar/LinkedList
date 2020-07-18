using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Transactions;

namespace LinkedListPart2
{
    class LinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            this.Count = 0;
        }

        public void AddFirst(T value)
        {
            if (Head == null)
            {
                Head = new Node<T>(value);
                Tail = Head;
                Count++;
            }

            else
            {
                var newnode = new Node<T>(value);
                newnode.next = Head;
                Head = newnode;
                Count++;

            }
        }

        public void AddLast(T value)
        {
            if (Head == null)
            {
                Head = new Node<T>(value);
                Tail = Head;
                Count++;
            }

            else
            {
                var newnode = new Node<T>(value);
                Tail.next = newnode;
                Tail = newnode;
                Count++;

            }
        }

        public void AddBefore(Node<T> given, T value)
        {
            var currentNode = Head;
            while ((currentNode.next != null))
            {
                if (currentNode.next == given)
                {
                    Node<T> newnode = new Node<T>(value);
                    newnode.next = given;
                    currentNode.next = newnode;
                    Count++;
                }

                else
                {
                    currentNode = currentNode.next;
                }

            }
        }

        public void AddAfter(T givenValue, T value)
        {
            Node<T> given = Head;

            while (given != null)
            {
                if (given.value.Equals(givenValue))
                {
                    break;
                }

                given = given.next;
            }
            

            if (Tail == given || given == null)
            {
                AddLast(value);
                return;
            }

            var newnode = new Node<T>(value);
            newnode.next = given.next;
            given.next = newnode;
            Count++;
            //var currentNode = Head;

            //while (currentNode.next != null)
            //{
            //    if (currentNode == given)
            //    {
            //        Node<T> newnode = new Node<T>(value);
            //        newnode.next = currentNode.next;
            //        currentNode.next = newnode;
            //        Count++;
            //        break;
            //    }
            //    else
            //    {
            //        currentNode = currentNode.next;
            //    }
            //}
        }

        public bool RemoveFirst()
        {
            if (Head.value == null)
            {
                return false;
            }

            else
            {
                Head = Head.next;
                Count--;
            }
            return true;
        }

        public bool RemoveLast()
        {
            var currentNode = Head;
            if (currentNode == null)
            {
                return false;
            }

            else
            {
                while (currentNode.next != Tail)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = null;
                Tail = currentNode;
                //update count then return true
                Count--;
                return true;
            }
        }

        public bool Remove(T value)
        {
            if(Head.value.Equals(value))
            {
                RemoveFirst();
                Count--;
                return true;
            }
            else if(Head.value == null)
            {
                return false;
            }

            else
            {
                var currentNode = Head;
                while (currentNode.next != null && currentNode != Tail)
                {
                    if (currentNode.next.value.Equals(value))
                    {
                        currentNode.next = currentNode.next.next;
                        Count--;
                        return true;
                        

                    }

                    else
                    {
                        currentNode = currentNode.next;
                    }
                }
                return false;
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }


        public bool Contains(T val)
        {
            Node<T> current = Head;

            for (int i = 0; i < Count; i++, current = current.next)
            {
                if (val.Equals(current.value))
                {
                    return true;
                }
            }

            return false;
        }

        Node<T> Search(T value)
        {
            var currentNode = Head;
            while(currentNode.next != null)
            {
                if (currentNode.value.Equals(value))
                {
                    return currentNode;
                }

                else
                {
                    currentNode = currentNode.next;
                }
            }
            return null;
        }
    }
}
