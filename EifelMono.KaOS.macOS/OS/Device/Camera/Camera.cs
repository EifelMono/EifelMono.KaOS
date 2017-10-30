using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.macOS.Camera))]
namespace EifelMono.KaOS.macOS
{
    public class Camera : CameraCore
    {
        public override bool IsAvailable => false;
    }
}
