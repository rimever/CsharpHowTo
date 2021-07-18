using System;

namespace RealtimeKeyscan
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; ; i++)
            {
                Console.Write($"{i}");
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    Console.WriteLine();
                    Console.WriteLine($"Some key is pressed.Pressed key is {key.Key}.Aborted");
                    break;
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}