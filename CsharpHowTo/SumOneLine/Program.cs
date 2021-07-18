using System;
using System.Linq;

namespace SumOneLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Enumerable.Range(1, 100).Where(c => (c % 2) == 0).Sum());
            Console.WriteLine(Enumerable.Range(1, 50).Sum(c => c * 2));
        }
    }
}