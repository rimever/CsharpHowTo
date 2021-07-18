using System;
using System.Runtime.Remoting;

namespace DynamicType
{
    class A
    {
        public void Sub()
        {
            Console.WriteLine("I'm class A");
        }
    }

    class B
    {
        public void Sub(string a = "Dummy")
        {
            Console.WriteLine("I'm class B");
        }
    }
    class Program
    {
        private static void CommonWork(dynamic arg)
        {
            arg.Sub();
        }
        static void Main(string[] args)
        {
            CommonWork(new A());
            CommonWork(new B());
        }
    }
}