using System;

namespace Finalizer
{
    class Sample:IDisposable
    {
        public Sample()
        {
            Console.WriteLine("私、産まれました！");
        }

        ~Sample()
        {
            Console.WriteLine("私、消えます");
        }

        public void Dispose()
        {
            Console.WriteLine("私、Disposeされました！");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Sample();
            Console.WriteLine($"a of {a} is here");
            a = null;
            GC.Collect();
            using var b = new Sample();
            Console.WriteLine($"b of {b} is here!");
        }
    }
}