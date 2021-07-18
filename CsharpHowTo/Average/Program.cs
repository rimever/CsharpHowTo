using System;
using System.Linq;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4};
            var average = array.Average();
            Console.WriteLine($"Average is {average}");
        }
    }
}