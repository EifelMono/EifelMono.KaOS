using System;

namespace EifelMono.KaOS.Extensions
{
    public static partial class Log
    {
        public static class Kind
        {
            public const int Exception= 0b0_0000_0001;
            public const int Trace =    0b0_0000_0010;
            public const int Info =     0b0_0000_0100;
            public const int Error =    0b0_0000_1000;
            public const int Warning =  0b0_0001_0000;
            public const int Debug =    0b0_0010_0000;
        }
    }
}
