using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[3, 3];
            array1[1, 2] = 123;
            Console.WriteLine($"array1[1,2] = {array1[1, 2]}");

            int[][] array2 = new int[][] {new int[3], new int[3], new int[3]};
            array2[1][2] = 123;
            Console.WriteLine($"array2[1,2] = {array2[1][2]}");
        }
    }
}