using System;
namespace EifelMono.KaOS.Implementation.OSx
{
    public class Platform : IPlatform
    {
        public bool IsAvailable => true;

        public PlatformKind Kind => PlatformKind.Android;
    }
}
