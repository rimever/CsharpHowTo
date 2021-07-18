using System;

namespace UpperOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "Jack Knife";
            foreach (var item in s)
            {
                if (Char.IsUpper(item)) Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}