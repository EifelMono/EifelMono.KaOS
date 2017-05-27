using System;
namespace EifelMono.KaOS.Implementation.OSx
{
    public class Camera : ICamera
    {
        public bool IsAvailable => true;

        public ITourch Tourch => new Lazy<ITourch>(() => new Tourch()).Value;

        public CameraKind[] AvailableCameras()
        {
            throw new NotImplementedException();
        }
    }
}
