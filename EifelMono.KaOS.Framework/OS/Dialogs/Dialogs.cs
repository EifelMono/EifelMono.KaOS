using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Framework.Dialogs))]
namespace EifelMono.KaOS.Framework
{
    public class Dialogs : DialogsCore
    {
        public override bool IsAvailable => false;
    }
}
