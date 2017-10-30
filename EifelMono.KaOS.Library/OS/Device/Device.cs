using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Library.Device))]
namespace EifelMono.KaOS.Library
{
    public class Device : DeviceCore
    {
        public override bool IsAvailable => false;
        public override PlatformKind Platform => PlatformKind.Library;
    }
}
