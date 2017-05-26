using System;
namespace EifelMono.KaOS.Implementation.OSx
{
    public class Platform : IPlatform
    {
        public PlatformKind Kind => PlatformKind.macOS;

        public bool IsAvailable => true;
    }
}
