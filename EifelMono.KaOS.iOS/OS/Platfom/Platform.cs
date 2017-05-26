using System;
namespace EifelMono.KaOS.Implementation.OSx
{
    public class Platform : IPlatform
    {
        public PlatformKind Kind => PlatformKind.iOS;

        public bool IsAvailable => true;
    }
}
