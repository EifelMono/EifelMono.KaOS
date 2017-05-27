using System;
using System.Collections.Generic;

namespace EifelMono.KaOS.Implementation.OSx
{
    public class Camera : ICamera
    {
        public bool IsAvailable => true;

        public ITourch Tourch => new Lazy<ITourch>(() => new Tourch()).Value;

        public List<CameraKind> AvailableCameras()
        {
            var availableCameras = new List<CameraKind>();
            OS.Developer.NotImplemented();
            return availableCameras;
        }
    }
}
