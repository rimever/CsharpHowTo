using System;

namespace Negative
{
    class Program
    {
        private static void ParseAndNegative(string s)
        {
            int.TryParse(s, out int v);
            Console.Write(v);
            Console.Write(">>>>");
            v = -v;
            Console.WriteLine(v);
        }

        private static void ParseAndNegativeChecked(string s)
        {
            try
            {
                int.TryParse(s, out int v);
                Console.Write(v);
                Console.Write(">>>>");
                checked
                {
                    v = -v;
                }
                Console.WriteLine(v);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow");
            }
        }
        static void Main(string[] args)
        {
            ParseAndNegative("-1234567890");
            ParseAndNegative("-2147483648");
            ParseAndNegativeChecked("-2147483648");
        }
    }
}