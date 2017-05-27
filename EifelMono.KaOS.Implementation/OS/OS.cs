using System;
using EifelMono.KaOS;

[assembly: BackDoor(typeof(EifelMono.KaOS.Implementation.BackDoor.OS))]

namespace EifelMono.KaOS.Implementation.BackDoor
{
    public class OS : IOS
    {
        private Lazy<IApplication> _Application = new Lazy<IApplication>(() => new OSx.Application());

        public IApplication Application => _Application.Value;

        private Lazy<ISystem> _System = new Lazy<ISystem>(() => new System());

        public ISystem System => _System.Value;

        private Lazy<IDevice> _Device = new Lazy<IDevice>(() => new OSx.Device());

        public IDevice Device => _Device.Value;

        private Lazy<IDialogs> _Dialogs = new Lazy<IDialogs>(() => new OSx.Dialogs());

        public IDialogs Dialogs => _Dialogs.Value;

    }
}
