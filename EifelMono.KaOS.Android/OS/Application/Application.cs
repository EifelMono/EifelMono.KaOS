using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Android.Application))]
namespace EifelMono.KaOS.Android
{
    public class Application : ApplicationCore
    {
        public override bool IsAvailable { get => false; }
    }
}