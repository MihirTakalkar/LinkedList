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

        public override string ToString()
        {
            return $"Value: {value}, Next: {next?.value.ToString() ?? "null"}";
        }

    }

    
}
