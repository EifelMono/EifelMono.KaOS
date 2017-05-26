using System;
namespace EifelMono.KaOS.Implementation.OS.Real
{
    public class Platform : IPlatform
    {
        public PlatformKind Kind => PlatformKind.Windows;

        public bool IsAvailable => true;
    }
}
