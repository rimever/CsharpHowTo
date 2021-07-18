using System;
using System.Collections.Generic;
using System.Linq;

namespace Max3
{
    class Program
    {
        private static IEnumerable<T> CreateEnumerable<T>(params T[] p) => p;
        static void Main(string[] args)
        {
            int a = 1234;
            int b = 999;
            int c = 4949;
            // Math.Max
            int max1 = Math.Max(a, Math.Max(b, c));
            Console.WriteLine($"{a},{b},{c}の最大値は{max1}");
            // LINQ
            int max2 = new int[] {a, b, c}.Max();
            Console.WriteLine($"{a},{b},{c}の最大値は{max2}");
            // LINQ + Service Method
            int max3 = CreateEnumerable(a, b, c).Max();
            Console.WriteLine($"{a},{b},{c}の最大値は{max3}");
        }
    }
}