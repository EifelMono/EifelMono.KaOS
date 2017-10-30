using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Android.Device))]
namespace EifelMono.KaOS.Android
{
    public class Device : DeviceCore
    {
        public override bool IsAvailable => false;
        public override PlatformKind Platform => PlatformKind.Android;
    }
}
