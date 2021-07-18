using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i > 5) if (i < 7) continue; else Console.Write($"{i} ");
            }
            Console.WriteLine();

            for (int i = 0; i < 9; i++)
            {
                if (i > 5) { if (i > 7) continue; } else Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}