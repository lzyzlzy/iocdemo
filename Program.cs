using iocdemo.Extensions;
using System;
using System.Runtime.InteropServices;

namespace iocdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new IoCContainerBuilder().UseStartup<Startup>().Build();
            var runner = container.Inject<Runner>();
            runner.Go();
            Console.ReadLine();
        }
    }
}
