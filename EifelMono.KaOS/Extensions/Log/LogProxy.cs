using System;
using EifelMono.KaOS.Extensions;

namespace EifelMono.KaOS.Extensions
{
    public class LogProxy: ILogProxy
    {
        public bool FileNameOnly { get; set; } = true;

        public virtual void Log(KaOS.Extensions.Log.Detail details)
        {
        }
    }
}
