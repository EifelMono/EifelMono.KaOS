using System;
using EifelMono.KaOS;

[assembly: BackDoor(typeof(EifelMono.KaOS.Implementation.OS.OS))]
namespace EifelMono.KaOS.Implementation.OS
{
     public class OS : IOS
    {
        public ISystem System => (new Lazy<ISystem>(() => new System()).Value);
    }
}
