using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Android.Tourch))]
namespace EifelMono.KaOS.Android
{
    public class Tourch : TourchCore
    {
        public override bool IsAvailable => false;
    }
}