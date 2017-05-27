using System;
using AudioToolbox;

namespace EifelMono.KaOS.Implementation.OSx
{
    public class Device : IDevice
    {
        public PlatformKind PlatformKind => PlatformKind.macOS;

        public bool IsAvailable => true;

        public ICamera Camera => new Lazy<ICamera>(() => new Camera()).Value;

        public void Vibrate(int time = -1)
        {
            EifelMono.KaOS.OS.Developer.NoEquivalentFunctionAvailable("");
        }
    }
}
