using System;
using AudioToolbox;

namespace EifelMono.KaOS.Implementation.OSx
{
    public class Device : IDevice
    {
        public PlatformKind PaltformKind => PlatformKind.macOS;

        public bool IsAvailable => true;

        public void Vibrate(int time = -1)
        {
            EifelMono.KaOS.OS.Developer.NoEquivalentFunctionAvailable("");
        }
    }
}
