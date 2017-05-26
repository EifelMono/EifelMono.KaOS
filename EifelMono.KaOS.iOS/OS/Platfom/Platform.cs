using System;
namespace EifelMono.KaOS.Implementation.OS.Real
{
    public class Platform : IPlatform
    {
        public PlatformKind Kind => PlatformKind.iOS;

        public bool IsAvailable => true;
    }
}
