using System;
namespace EifelMono.KaOS.Implementation.OS.Real
{
    public class Platform : IPlatform
    {
        public PlatformKind Kind => PlatformKind.macOS;

        public bool IsAvailable => true;
    }
}
