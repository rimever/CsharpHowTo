using System;

namespace NumberCharCode
{
    class Program
    {
        private static bool CharTest2(char ch)
        {
            return "0123456789".Contains(ch);
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"CharTest2('A')={CharTest2('A')}");
            Console.WriteLine($"CharTest2('A')={CharTest2('3')}");
        }
    }
}