using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Library.Tourch))]
namespace EifelMono.KaOS.Library
{
    public class Tourch : TourchCore
    {
        public override bool IsAvailable => false;
    }
}