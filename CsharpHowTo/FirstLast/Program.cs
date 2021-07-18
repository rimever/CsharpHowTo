using System;
using System.Linq;

namespace FirstLast
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array =
            {
                "クラウド","セフィロス","ティファ","エアリス","バレット"
            };
            foreach (var item in array)
            {
                if (item.FirstOrDefault() == 'セ' && item.LastOrDefault() == 'ス') Console.WriteLine(item);
            }
        }
    }
}