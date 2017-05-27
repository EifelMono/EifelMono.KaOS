using System;

namespace EifelMono.KaOS.Implementation.OSx
{
    public class Device : IDevice
    {
        public bool IsAvailable => true;

        public PlatformKind PaltformKind => PlatformKind.Android;

        public void Vibrate(int time = -1)
        {
            throw new NotImplementedException();
        }
    }
}
