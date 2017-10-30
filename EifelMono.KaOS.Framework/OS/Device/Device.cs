using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Framework.Device))]
namespace EifelMono.KaOS.Framework
{
    public class Device : DeviceCore
    {
        public override bool IsAvailable => false;
        public override PlatformKind Platform => PlatformKind.Framework;
    }
}
