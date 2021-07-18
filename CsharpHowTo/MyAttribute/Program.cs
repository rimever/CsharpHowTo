using System;
using System.Reflection;

namespace MyAttribute
{
    class MyAttribute : Attribute
    {
    }

    class Program
    {
        public int MyProperty1 { get; set; }
        [My] public int MyProperty2 { get; set; }

        static void Main(string[] args)
        {
            foreach (var item in typeof(Program).GetProperties())
            {
                Console.Write($"{item.Name}は{nameof(MyAttribute)}属性を");
                if (item.GetCustomAttribute(typeof(MyAttribute)) == null)
                {
                    Console.WriteLine("持っていません。");
                }
                else
                {
                    Console.WriteLine("持っています。");
                }
            }
        }
    }
}