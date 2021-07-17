using System;

namespace SameNameMethod
{
    class Program
    {
        class A
        {
            internal void MyMethodA()
            {
                Console.WriteLine("I'm MyMethodA in class A.");
            }

            internal virtual void MyMethodB()
            {
                Console.WriteLine("I'm MyMethodB in class A.");
            }
        }

        class B : A
        {
            internal new void MyMethodA()
            {
                Console.WriteLine("I'm MyMethodA in class B.");
            }

            internal override void MyMethodB()
            {
                Console.WriteLine("I'm MyMethodB in class B.");
            }
        }
        static void Main(string[] args)
        {
            B obj = new B();
            A objTypeA = obj;
            obj.MyMethodA();
            objTypeA.MyMethodA();
            obj.MyMethodB();
            objTypeA.MyMethodB();
        }
    }
}