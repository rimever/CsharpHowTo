using System;
using System.Linq;

namespace AtoZ
{
    class Program
    {
        static void Main(string[] args)
        {
            var atoz3 = string.Concat(Enumerable.Range('A', 26).Select(c => (char) c));
            Console.WriteLine(atoz3);
        }
    }
}