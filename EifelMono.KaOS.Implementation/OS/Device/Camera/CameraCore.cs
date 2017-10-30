using System;
using System.Collections.Generic;

namespace EifelMono.KaOS.Implementation
{
    public class CameraCore : ICamera
    {
        #region Implemented
        private Lazy<ITourch> _Tourch = new Lazy<ITourch>(() => BackDoor.New<ITourch, TourchCore>());

        public ITourch Tourch => _Tourch.Value;
        #endregion

        public virtual bool IsAvailable => throw new NotImplementedException();

        public virtual List<CameraKind> AvailableCameras()
        {
            throw new NotImplementedException();
        }
    }
}
