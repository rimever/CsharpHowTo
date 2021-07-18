using System;

namespace Trim
{
    class Program
    {
        static void Main(string[] args)
        {
            var src = "{[山田太郎（一年）柔道部]}";
            int from = 0;
            int to = src.Length - 1;
            for (;;)
                if (!"([{".Contains(src[from++]))
                    break;
            for (;;)
                if (!")]}".Contains(src[to--]))
                    break;
            var dst0 = src.Substring(from - 1, to - from + 3);
            Console.WriteLine(dst0);

            var dst1 = src.TrimStart('(', '{', '[').TrimEnd(')', '}', ']');
            Console.WriteLine(dst1);

            var dst2 = src.Trim('(', '{', '[', ')', '}', ']');
            Console.WriteLine(dst2);
        }
    }
}