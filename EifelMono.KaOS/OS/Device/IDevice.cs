using System;
namespace EifelMono.KaOS
{
    public interface IDevice: IAvailable
    {
        PlatformKind PaltformKind { get; }

        void Vibrate(int time = -1);
    }
}
