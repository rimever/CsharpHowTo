using System;
using System.Linq;

namespace StringEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            const string src = "吉良瞳子";
            var dst = new string(src.TakeLast(2).ToArray());
            Console.WriteLine($"文字列の最後の２文字は{dst}");
        }
    }
}