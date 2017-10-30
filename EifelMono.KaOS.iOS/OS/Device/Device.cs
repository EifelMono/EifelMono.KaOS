using System;
using AudioToolbox;
using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.iOS.Device))]
namespace EifelMono.KaOS.iOS
{
    public class Device : DeviceCore
    {
        public override bool IsAvailable => true;
        public override PlatformKind Platform => PlatformKind.iOS;

        public override void Vibrate(int time = -1)
        {
            SystemSound.Vibrate.PlaySystemSound();
        }
    }
}
