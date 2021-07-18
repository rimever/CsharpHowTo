using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse
{
    class Program
    {
        private static void Recursion(IEnumerable<int> e)
        {
            if (e.Count() > 0)
            {
                Recursion(e.Skip(1));
                Console.Write(e.First());
            }
        }

        static void Main(string[] args)
        {
            int[] array = {1, 2, 3};
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[array.Length - i - 1]);
            }

            Console.WriteLine();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
            }

            Console.WriteLine();
            foreach (var item in array.Reverse())
            {
                Console.Write(item);
            }

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array.Skip(array.Length - i - 1).First());
            }

            Console.WriteLine();

            IEnumerable<int> a = array.ToArray();
            for (;;)
            {
                if (a.Count() == 0) break;
                Console.Write(a.Last());
                a = a.Take(a.Count() - 1);
            }

            Console.WriteLine();
            Recursion(array);
            Console.WriteLine();
        }
    }
}