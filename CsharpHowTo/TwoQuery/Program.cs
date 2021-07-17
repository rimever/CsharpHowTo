using System;
using System.Linq;

namespace TwoQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {2, 3, 5, 7, 11, 13, 17};
            var q1 = array.Where(c => c < 10).Select(c => c * c);
            var q2 = from c in array where c < 10 select c * c;
            foreach (var item in q1)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            foreach (var item in q2)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}