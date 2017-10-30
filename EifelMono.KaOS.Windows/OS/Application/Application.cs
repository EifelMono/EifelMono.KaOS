using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Windows.Application))]
namespace EifelMono.KaOS.Windows
{
    public class Application : ApplicationCore
    {
        public override bool IsAvailable { get => false; }
    }
}