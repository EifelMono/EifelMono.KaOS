﻿using System;

namespace EifelMono.KaOS.Extensions
{
    public static partial class Log
    {
        public class ExDetail : Detail
        {
            /// <summary>
            /// Exception of this Log Detail
            /// </summary>
            /// <value>The ex.</value>
            public Exception Ex { get; set; }
        }
    }
}
