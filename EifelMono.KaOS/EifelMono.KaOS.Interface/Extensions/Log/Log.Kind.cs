using System;

namespace EifelMono.KaOS.Extensions
{
    public static partial class Log
    {
        public static class Kind
        {
            public static string Trace {get; private set;} = nameof(Trace);
            public static string Info { get; private set; } = nameof(Info);
            public static string Error { get; private set; } = nameof(Error);
            public static string Warning { get; private set; } = nameof(Warning);
            public static string Debug { get; private set; } = nameof(Debug);
            public static string Exception { get; private set; } = nameof(Exception);
        }
    }
}
