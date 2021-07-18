using System;

namespace NumberOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var target = 4649;

            var s1 = target.ToString();
            var width1 = s1.Length;
            Console.WriteLine($"{target}は{width1}桁です。");

            // 対数を用いて桁数を割り出す
            var width2raw = Math.Log10(target);
            var width2 = Math.Ceiling(width2raw);
            Console.WriteLine($"{target}は{width2}桁です。（切り上げ前は{width2raw}）");
        }
    }
}