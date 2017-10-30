using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Framework.Tourch))]
namespace EifelMono.KaOS.Framework
{
    public class Tourch : TourchCore
    {
        public override bool IsAvailable => false;
    }
}