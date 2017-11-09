using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Library.Application))]
namespace EifelMono.KaOS.Library
{
    public class Application : ApplicationCore
    {
        public override bool IsAvailable { get => false; }

    }
}