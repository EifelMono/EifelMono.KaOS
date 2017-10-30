using System;
using System.Collections.Generic;
using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Framework.Camera))]
namespace EifelMono.KaOS.Framework
{
    public class Camera : CameraCore
    {
        public override bool IsAvailable => false;
    }
}
