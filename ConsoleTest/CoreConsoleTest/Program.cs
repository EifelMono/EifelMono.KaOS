using System;
using EifelMono.KaOS;

namespace CoreConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            EifelMono.KaOS.Implementation.KaOS.Init();
            Console.WriteLine("Hello World!");
            Console.WriteLine(OS.Device.Platform);
        }
    }
}
