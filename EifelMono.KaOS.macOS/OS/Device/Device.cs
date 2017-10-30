using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.macOS.Device))]
namespace EifelMono.KaOS.macOS
{
    public class Device : DeviceCore
    {
        public override bool IsAvailable => true;
        public override PlatformKind Platform => PlatformKind.macOS ;
    }
}
