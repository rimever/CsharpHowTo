using System;
using System.Text;

namespace SwapChar
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "太郎くんの英語はA、国語はB";
            // \0は通常使用しない文字
            var good1 = s.Replace('A', '\0').Replace('B', 'A').Replace('\0', 'B');
            Console.WriteLine($"{good1}");
            var good2 = new StringBuilder();
            foreach (var item in s)
            {
                good2.Append(item switch {'A' => 'B', 'B' => 'A', _ => item});
            }
            Console.WriteLine($"{good2}");
        }
    }
}