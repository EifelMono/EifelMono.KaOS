using System;

namespace EifelMono.KaOS.Platform
{
    public class DeviceCore : IDevice
    {
        #region Implemented
        private Lazy<ICamera> _Camera = new Lazy<ICamera>(() => BackDoor.New<ICamera, CameraCore>());

        public ICamera Camera => _Camera.Value;
        #endregion

        #region ToBe Implemented

        public virtual PlatformKind Platform => PlatformKind.Unknown;

        public virtual bool IsAvailable => throw new NotImplementedException();

        public virtual void Vibrate(int time = -1)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
