using System;
namespace EifelMono.KaOS
{
    public interface ICamera : IAvailable
    {
        CameraKind[] AvailableCameras();

        ITourch Tourch { get; }
    }
}
