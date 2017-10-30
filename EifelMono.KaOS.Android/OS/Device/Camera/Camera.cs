using System;
using System.Collections.Generic;
using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Android.Camera))]
namespace EifelMono.KaOS.Android
{
    public class Camera : CameraCore
    {
        public override bool IsAvailable => false;
    }
}
