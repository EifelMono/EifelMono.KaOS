using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Windows.Dialogs))]
namespace EifelMono.KaOS.Windows
{
    public class Dialogs : DialogsCore
    {
        public override bool IsAvailable => false;
    }
}
