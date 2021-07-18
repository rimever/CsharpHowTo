using System;

namespace DiffDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var time1 = new DateTime(2020, 1, 1, 10, 37, 0);
            var time2 = new DateTime(2020, 1, 1, 11, 21, 0);
            Console.WriteLine(time2.Subtract(time1));
            Console.WriteLine(time2 - time1);
        }
    }
}