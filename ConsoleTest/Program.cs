using System;
using System.IO;
using EifelMono.KaOS;
using EifelMono.KaOS.Extensions;
using Newtonsoft.Json;

namespace ConsoleTest
{
    public class Mimes : EnumOf<string>
    {
        public static Mimes Test1 { get; private set; } = new Mimes { Value = "Test1" };
        public static Mimes Test3 { get; private set; } = new Mimes { Value = "Test2" };
    }

    class MainClass
    {
        public static void Main(string[] args)
        {

            EifelMono.KaOS.Implementation.KaOS.Init();
            EifelMono.KaOS.KaOS.Init();

            Console.WriteLine(OS.Device.PlatformKind);

            OS.Dialogs.OpenFileDialog(Directory.GetCurrentDirectory());

            string s11 = JsonConvert.SerializeObject(Mimes.Test1);
            Log.Proxy = new DebugLogProxy();

            var X= OS.System.IO.Directory.GetFiles("/");

            Mimes x = Mimes.Test1;
            Mimes z = Mimes.Test1;
            if (x== z)
                Console.WriteLine("x==z");
            z = Mimes.Test3;
            if (x != z)
                Console.WriteLine("x!=z");
            string s1 = JsonConvert.SerializeObject(x);

            var y = JsonConvert.DeserializeObject<Mimes>(s1);
            if (y != z)
                Console.WriteLine("y!=z");
            z = Mimes.Test1;
            if (y == z)
                Console.WriteLine("y==z");
          
            Test1();
            Test2();

            var l1 = "Level 1".LogInfo();
            var l11 = "Level 1.1".LogInfo(l1);
            var l12 = "Level 1.2".LogInfo(l1);
            var l111 = "Level 1.1.1".LogInfo(l11);
            var l2 = "Level 2".LogInfo();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        public static void Test1()
        {
            "KarlX".LogInfo();
            Heinz();

            void Heinz()
            {
                "HeinzX".LogInfo();
            }
        }

        public static void Test2()
        {

        }
    }
}
