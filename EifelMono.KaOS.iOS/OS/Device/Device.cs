using System;
using AudioToolbox;

namespace EifelMono.KaOS.Implementation.OSx
{
    public class Device : IDevice
    {
        public PlatformKind PaltformKind => PlatformKind.iOS;

        public bool IsAvailable => true;

        public void Vibrate(int time = -1)
        {
            SystemSound.Vibrate.PlaySystemSound();
        }
    }
}
