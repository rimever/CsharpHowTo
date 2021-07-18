using System;

namespace Record
{
    public record ProductInfo(string Name, int Price);
    class Program
    {
        private static void Dump(ProductInfo info)
        {
            Console.WriteLine($"{info.Name}: {info.Price}yen");
        }
        static void Main(string[] args)
        {
            var info = new ProductInfo("Coffee", 120);
            Dump(info);
            var info2 = info with {Price = 130};
            Dump(info2);
        }
    }
}