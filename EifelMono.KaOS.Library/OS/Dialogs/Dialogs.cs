using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Library.Dialogs))]
namespace EifelMono.KaOS.Library
{
    public class Dialogs : DialogsCore
    {
        public override bool IsAvailable => false;
    }
}
