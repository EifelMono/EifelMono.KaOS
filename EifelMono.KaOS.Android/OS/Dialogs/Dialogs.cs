using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.Android.Dialogs))]
namespace EifelMono.KaOS.Android
{
    public class Dialogs : DialogsCore
    {
        public override bool IsAvailable => false;
    }
}
