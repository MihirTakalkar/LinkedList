using System;

namespace LinkedListPart2
{
    class Program
    {
        //static bool IsPrime(int num)
        //{
        //    if (num < 2)
        //    {
        //        return false;
        //    }
        //    else if (num == 2)
        //    {
        //        return true;
        //    }
        //    else if (num % 2 == 0)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        //for (int i = 3; i <= Math.Sqrt(num) + 1; i+=2)
        //        //{
        //        //    if (num % i == 0)
        //        //    {
        //        //        return false;
        //        //    }
        //        //}

        //        for (int i = 3; i < num; i++)
        //        {
        //            if (num % i == 0)
        //            {
        //                return false;
        //            }
        //        }

        //        return true;
        //    }

        //}

        static void Main(string[] args)
        {
            Node<int> n = new Node<int>(5);

            Console.WriteLine(n.value);


            Node<int> j = new Node<int>(6);

            Console.WriteLine(j.value);

            Node<int> k = n;

            Console.WriteLine(k.value);

            k = j;

            Console.WriteLine(k.value);


        }
    }
}
