using System;
using System.Collections.Generic;

namespace Immutable
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "hello";
            Console.WriteLine(s1);
            var list = new List<int>();
            list.Add(123);
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            list[0] = 456;
            list.Add(789);
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            int[] array = {123};
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            array[0] = 456;
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}