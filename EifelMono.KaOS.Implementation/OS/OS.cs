using System;
using EifelMono.KaOS;

[assembly: BackDoor(typeof(EifelMono.KaOS.Implementation.OS))]
namespace EifelMono.KaOS.Implementation
{
    public class OS : IOS
    {
        private Lazy<IApplication> _Application = new Lazy<IApplication>(() => BackDoor.New<IApplication, ApplicationCore>());
        public IApplication Application => _Application.Value;

        private Lazy<IDevice> _Device = new Lazy<IDevice>(() => BackDoor.New<IDevice, DeviceCore>());
        public IDevice Device => _Device.Value;

        private Lazy<IDialogs> _Dialogs = new Lazy<IDialogs>(() => BackDoor.New<IDialogs, DialogsCore>());
        public IDialogs Dialogs => _Dialogs.Value;

        public static void Init()
        {
            
        }
    }
}