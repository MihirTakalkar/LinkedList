using System;
using System.Collections.Generic;

namespace LinkedListPart2
{
    class Program
    {

        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            bool test;

            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);

            list.AddAfter(3, 66);
            list.AddAfter(1, 55);

            for (int i = 0; i < 100; i++)
            {
                test = list.Contains(i);

                if (test)
                {
                    Console.WriteLine($"Value: {i} = {test}");
                }
            }

        }
    }
}
