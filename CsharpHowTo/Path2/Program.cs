using System;
using System.IO;
using System.Linq;

namespace Path2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] {"a", "b", "c"};
            var path1 = Path.Combine(array[0], array[1], array[2]);
            Console.WriteLine($"path1={path1}");
            var path2 = Path.Combine(array);
            Console.WriteLine($"path2={path2}");
        }
    }
}