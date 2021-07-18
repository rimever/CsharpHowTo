using System;

namespace DivByZero
{
    class Program
    {
        private static void Div1(decimal x, decimal y)
        {
            Console.WriteLine(x / y);
        }

        private static void Div2(double x, double y)
        {
            Console.WriteLine(x / y);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("div1の利用");
            try
            {
                Div1(0, 0);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("0で割りました。");
            }

            Console.WriteLine("div2の利用");
            try
            {
                Div2(0, 0);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("0で割りました。");
            }
        }
    }
}