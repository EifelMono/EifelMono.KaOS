using System;
namespace EifelMono.KaOS.Extensions
{
    public  static partial class Log
    {
        public class Details
        {
            /// <summary>
            /// Type of this Log Detail
            /// </summary>
            /// <value>The type.</value>
            public Type Type { get; set; }

            /// <summary>
            /// Message of this Log Detail
            /// </summary>
            /// <value>The message.</value>
            public string Message { get; set; }

            /// <summary>
            /// CallerMemberName of this Log Detail
            /// </summary>
            /// <value>The name of the caller member.</value>
            public string CallerMemberName { get; set; }

            /// <summary>
            /// CallerLineNumber of this Log Detail
            /// </summary>
            /// <value>The caller line number.</value>
            public int CallerLineNumber { get; set; }

            /// <summary>
            /// CallerLineNumber of this Log Detail
            /// </summary>
            /// <value>The caller file path.</value>
            public string CallerFilePath { get; set; }
        }
    }
}
