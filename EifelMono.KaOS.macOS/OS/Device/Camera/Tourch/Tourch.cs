using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.macOS.Tourch))]
namespace EifelMono.KaOS.macOS
{
    public class Tourch : TourchCore
    {
        public override bool IsAvailable => false;
    }
}