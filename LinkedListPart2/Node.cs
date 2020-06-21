using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPart2
{
    class Node<T>
    {
       public T value;
       public Node<T> next;

        public Node(T value)
        {
            this.value = value;
        }

    }

    
}
