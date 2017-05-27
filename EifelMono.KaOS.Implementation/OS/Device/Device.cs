using System;
namespace EifelMono.KaOS.Implementation
{
    public class Device : IDevice
    {
        public bool IsAvailable => OSxDevice != null && OSxDevice.IsAvailable;

        public static IDevice OSxDevice => new Lazy<IDevice>(() => new OSx.Device()).Value;

        public PlatformKind PaltformKind => OSxDevice.PaltformKind;

        public void Vibrate(int time = -1)
        {
            OSxDevice.Vibrate(time);
        }
    }
}
