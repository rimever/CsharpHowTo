﻿using System;

namespace SameCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
                if (!(i != 2 && i != 4)) Console.Write("[HIT]");
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
                if (i == 2 || i == 4) Console.Write("[HIT]");
            }
            Console.WriteLine();
        }
    }
}