using System;
namespace EifelMono.KaOS.Implementation.OS.Real
{
    public class Platform : IPlatform
    {
        public PlatformKind Kind => PlatformKind.FrameWork;

        public bool IsAvailable => true;
    }
}
