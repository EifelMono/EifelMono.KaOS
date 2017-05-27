using System;
using EifelMono.KaOS;

[assembly: BackDoor(typeof(EifelMono.KaOS.Implementation.BackDoor.OS))]

namespace EifelMono.KaOS.Implementation.BackDoor
{
    public class OS: IOS
    {
        public ISystem System => new Lazy<ISystem>(() => new System()).Value;

        public IDevice Device => new Lazy<IDevice>(() => new OSx.Device()).Value;

        public IDialogs Dialogs => new Lazy<IDialogs>(() => new OSx.Dialogs()).Value;
    }
}
