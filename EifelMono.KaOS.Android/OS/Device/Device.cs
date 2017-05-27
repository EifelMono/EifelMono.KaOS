using System;

namespace EifelMono.KaOS.Implementation.OSx
{
    public class Device : IDevice
    {
        public bool IsAvailable => true;

        public PlatformKind PlatformKind => PlatformKind.Android;

        public ICamera Camera => new Lazy<ICamera>(()=> new Camera()).Value;

        public void Vibrate(int time = -1)
        {
            throw new NotImplementedException();
        }
    }
}
