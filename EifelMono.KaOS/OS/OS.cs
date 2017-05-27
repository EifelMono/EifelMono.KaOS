using System;
namespace EifelMono.KaOS
{
    public static class OS
    {
        internal static IOS Instance => new Lazy<IOS>(() => BackDoor.Instance<IOS>()).Value;

        public static IApplication Application => Instance.Application;

        public static Developer Developer => new Developer();

        public static IDevice Device => Instance.Device;

        public static IDialogs Dialogs => Instance.Dialogs;

        public static ISystem System => Instance.System;
        /*
        public static IApplication Application { get { return Instance.Value.Application; } }

        public static ICamera Camera { get { return Instance.Value.Camera; } }

        public static IConnection Connection { get { return Instance.Value.Connection; } }

        public static IDetails Details { get { return Instance.Value.Details; } }

        public static IDevice Device { get { return Instance.Value.Device; } }

        public static IDevice Map { get { return Instance.Value.Device; } }

        public static IMedia Media { get { return Instance.Value.Media; } }

        public static INotification Notification { get { return Instance.Value.Notification; } }

        public static IUI UI { get { return Instance.Value.UI; } }

        public static IPhone Phone { get { return Instance.Value.Phone; } }
        */
    }
}
