using System;
using System.Linq;

namespace Single
{
    class Program
    {
        private static void CheckSingle1(int[] array)
        {
            array.ToList().ForEach(i => Console.Write($"{i} "));
            int c = array.Count(c => c == 1);
            if (c == 0) Console.WriteLine("に1はありません。");
            else if (c == 1) Console.WriteLine("に1は1つだけあります。");
            else Console.WriteLine("に1は2個以上です。");
        }

        private static void CheckSingle2(int[] array)
        {
            array.ToList().ForEach(i => Console.Write($"{i} "));
            try
            {
                int c = array.SingleOrDefault(c => c == 1);
                if (c == 0) Console.WriteLine("に1はありません。");
                else if (c == 1) Console.WriteLine("に1は1つだけあります。");
                else Console.WriteLine("不明です。");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("に1は2個以上です。");
            }
        }
        private static void CheckSingle3(int[] array)
        {
            array.ToList().ForEach(i => Console.Write($"{i} "));
            try
            {
                int c = array.Single(c => c == 1);
                Console.WriteLine("に1は1つだけあります");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("に1は無いか2個以上です。");
            }
        }
        static void Main(string[] args)
        {
            int[] array1 = {2, 2, 3};
            int[] array2 = {1, 2, 3};
            int[] array3 = {1, 2, 1};
            CheckSingle1(array1);
            CheckSingle1(array2);
            CheckSingle1(array3);
            CheckSingle2(array1);
            CheckSingle2(array2);
            CheckSingle2(array3);
            CheckSingle3(array1);
            CheckSingle3(array2);
            CheckSingle3(array3);
        }
    }
}