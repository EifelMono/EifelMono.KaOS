using System;
namespace EifelMono.KaOS.Implementation.OSx
{
    public class Device : IDevice
    {
        public PlatformKind PaltformKind => PlatformKind.Windows;

        public bool IsAvailable => true;

        public void Vibrate(int time = -1)
        {
            EifelMono.KaOS.OS.Developer.NotImplemented("");
        }
    }
}
