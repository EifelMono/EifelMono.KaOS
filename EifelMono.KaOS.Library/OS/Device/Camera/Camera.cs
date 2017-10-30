using System;
using System.Collections.Generic;
using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Library.Camera))]
namespace EifelMono.KaOS.Library
{
    public class Camera : CameraCore
    {
        public override bool IsAvailable => false;
    }
}
