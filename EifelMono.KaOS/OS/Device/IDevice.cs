using System;
namespace EifelMono.KaOS
{
    public interface IDevice: IAvailable
    {
        PlatformKind PlatformKind { get; }

        void Vibrate(int time = -1);

        ICamera Camera { get; }
    }
}
