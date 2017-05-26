using System;
namespace EifelMono.KaOS
{
    public interface IPlatform: IAvailable
    {
        PlatformKind Kind { get; }
    }
}
