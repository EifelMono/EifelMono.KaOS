using System;
namespace EifelMono.KaOS.Implementation.OSx
{
    public class Platform : IPlatform
    {
        public PlatformKind Kind => PlatformKind.FrameWork;

        public bool IsAvailable => true;
    }
}
