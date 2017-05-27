using System;
using System.Collections.Generic;

namespace EifelMono.KaOS
{
    public interface ICamera : IAvailable
    {
        List<CameraKind> AvailableCameras();

        ITourch Tourch { get; }
    }
}
