using System;

namespace PI
{
    class Program
    {
        static void Main(string[] args)
        {
            double paiD = Math.PI;
            Console.WriteLine(paiD);

            double paiF = MathF.PI;
            Console.WriteLine(paiF);
            
            //TODO: decimalは、必要な桁数を考えて、自力で定義するしかない
        }
    }
}