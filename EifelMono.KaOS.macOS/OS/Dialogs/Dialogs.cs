using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.macOS.Dialogs))]
namespace EifelMono.KaOS.macOS
{
    public class Dialogs : DialogsCore
    {
        public override bool IsAvailable => false;
    }
}
