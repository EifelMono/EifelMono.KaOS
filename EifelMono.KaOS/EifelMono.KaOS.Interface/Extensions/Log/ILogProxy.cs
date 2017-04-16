using System;

namespace EifelMono.KaOS.Extensions
{
    public interface ILogProxy
    {
        void Log(Log.Details details);
    }
}
