using System;

namespace EifelMono.KaOS.Implementation.OSx
{
    public class Device : IDevice
    {
        public bool IsAvailable => true;

        public PlatformKind PlatformKind => PlatformKind.Android;

        private Lazy<ICamera> _Camera = new Lazy<ICamera>(() => new Camera());

        public ICamera Camera => _Camera.Value;

        public void Vibrate(int time = -1)
        {
            throw new NotImplementedException();
        }
    }
}
