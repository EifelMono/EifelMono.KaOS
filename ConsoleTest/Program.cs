using System;
using EifelMono.KaOS.Extensions;

namespace ConsoleTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var l1= "Level 1".LogInfo();
            var l11 = "Level 1.1".LogInfo(l1);
            var l12 = "Level 1.2".LogInfo(l1);
            var l111 = "Level 1.1.1".LogInfo(l11);
            var l2 = "Level 2".LogInfo();
            Console.WriteLine("Hello World!");
        }
    }
}
