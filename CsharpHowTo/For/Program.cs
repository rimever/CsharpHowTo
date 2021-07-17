using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 255; i++) Console.Write($"{i} ");
            for (byte i = 0;; i++)
            {
                Console.Write($"{i} ");
                if (i == 255) break;
            }
            // 無限ループする
            // for (byte i = 0; i <= 255; i++) Console.Write($"{i} ");
        }
    }
}