using System;

namespace Capture
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            sub1();
            sub2();

            void sub1()
            {
                a = 1234;
            }

            void sub2()
            {
                Console.WriteLine(a);
            }
        }
    }
}