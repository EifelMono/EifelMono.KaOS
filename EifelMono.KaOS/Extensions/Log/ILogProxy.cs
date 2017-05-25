using System;

namespace EifelMono.KaOS.Extensions
{
    public interface ILogProxy
    {
        void Log(Log.Detail details);

        bool FileNameOnly { get; set; }
    }
}