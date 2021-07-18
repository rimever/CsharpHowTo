using System;
using System.Linq;

namespace Average2
{
    class Program
    {
        private static double Calculate1(int[] array)
        {
            var start = DateTimeOffset.Now;
            double sum = 0;
            Enumerable.Range(0, 10000).ToList().ForEach(c => sum += array.Average());
            Console.WriteLine(DateTimeOffset.Now - start);
            return sum;
        }

        private static double Calculate2(int[] array)
        {
            var start = DateTimeOffset.Now;
            double sum = 0;
            for (int i = 0; i < 10000; i++)
            {
                int s = 0;
                foreach (var item in array)
                {
                    s += item;
                }

                sum += ((double) s / (double) array.Length);
            }

            Console.WriteLine(DateTimeOffset.Now - start);
            return sum;
        }

        static void Main(string[] args)
        {
            int[] array = Enumerable.Range(0, 10000).ToArray();
            Calculate1(array);
            Calculate2(array);
            // Averageメソッドは便利だが、処理は速いわけではない。
        }
    }
}