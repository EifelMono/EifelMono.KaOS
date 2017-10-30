using System;
using System.Diagnostics;

namespace EifelMono.KaOS
{
    public static class OS
    {
        internal static Lazy<IOS> Instance => new Lazy<IOS>(
            () =>
            {
                var instance = BackDoor.Instance<IOS>();
                if (instance == null)
                    Debugger.Break();
                return instance;
            });

        public static IApplication Application => Instance.Value.Application;

        public static IDevice Device => Instance.Value.Device;

        public static IDialogs Dialogs => Instance.Value.Dialogs;
    }
}
