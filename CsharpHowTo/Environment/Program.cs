using System;

namespace Environment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool is64bitOs = System.Environment.Is64BitOperatingSystem;
            bool is64bitProcess = System.Environment.Is64BitProcess;
            bool is64bitPointer = IntPtr.Size == 8;
            Console.WriteLine((is64bitOs ? 64 : 32) + "bit OS");
            Console.WriteLine((is64bitProcess ? "64" : "32") + "bit Process");
            Console.WriteLine((is64bitPointer ? "64" : "32") + "bit Pointer");
        }
    }
}