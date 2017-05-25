using System;
namespace EifelMono.KaOS
{
    public interface ISystem: IAvailable
    {
        IIO IO { get; }
    }
}
