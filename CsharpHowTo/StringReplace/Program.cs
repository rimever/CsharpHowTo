using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            var src = "Fußball";
            var targetChar = 'ß';
            Console.WriteLine(src.Replace(targetChar.ToString(),"ss"));
        }
    }
}