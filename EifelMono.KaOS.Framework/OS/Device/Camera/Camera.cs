using System;
using System.Collections.Generic;

namespace EifelMono.KaOS.Implementation.OSx
{
    public class Camera : ICamera
    {
        public bool IsAvailable => true;

        private Lazy<ITourch> _Tourch = new Lazy<ITourch>(() => new Tourch());

        public ITourch Tourch => _Tourch.Value;

        public List<CameraKind> AvailableCameras()
        {
            var availableCameras = new List<CameraKind>();
            OS.Developer.NotImplemented();
            return availableCameras;
        }
    }
}
