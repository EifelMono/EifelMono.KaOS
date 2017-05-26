using System;
namespace EifelMono.KaOS.Implementation.OS
{
    public class Platform : IPlatform
    {
        public bool IsAvailable => Implementation != null && Implementation.IsAvailable;

        public static IPlatform Implementation => new Lazy<IPlatform>(() => new Real.Platform()).Value;

        public PlatformKind Kind => Implementation.Kind;
    }
}
