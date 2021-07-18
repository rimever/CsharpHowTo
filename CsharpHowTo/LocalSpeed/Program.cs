using System;

namespace LocalSpeed
{
    class Program
    {
        private static int count2 = 0;
        static void Main(string[] args)
        {
            int count1 = 0;
            const int loop = 1000000000;
            var start1 = DateTime.Now;
            for (int i = 0; i < loop; i++) local1();
            Console.WriteLine(DateTime.Now - start1);

            var start2 = DateTime.Now;
            for (int i = 0; i < 100; i++) local2();
            Console.WriteLine(DateTime.Now - start2); // static メソッドの方が早い

            void local1()
            {
                count1++;
            }

            static void local2()
            {
                count2++;
            }
        }
    }
}