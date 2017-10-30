using System;
using System.Collections.Generic;
using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Windows.Camera))]
namespace EifelMono.KaOS.Windows
{
    public class Camera : CameraCore
    {
        public override bool IsAvailable => false;
    }
}
