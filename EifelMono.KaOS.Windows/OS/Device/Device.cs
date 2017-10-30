using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Windows.Device))]
namespace EifelMono.KaOS.Windows
{
    public class Device : DeviceCore
    {
        public override bool IsAvailable => false;
        public override PlatformKind Platform => PlatformKind.Windows;
    }
}
