using System;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Console.Out.WriteLineAsync("Hello World");
        }
    }
}