using System;
namespace EifelMono.KaOS.Implementation.OSx
{
    public class Device : IDevice
    {
        public PlatformKind PaltformKind => PlatformKind.FrameWork;

        public bool IsAvailable => true;

        public void Vibrate(int time = -1)
        {
            OS.Developer.NoEquivalentFunctionAvailable("");
        }
    }
}
