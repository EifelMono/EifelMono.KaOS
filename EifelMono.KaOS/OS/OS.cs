using System;
namespace EifelMono.KaOS
{
    public static class OS
    {
        internal static Lazy<IOS> Instance { get; private set; } = new Lazy<IOS>(() => BackDoor.Instance<IOS>());

        public static ISystem System { get { return Instance.Value.System; } }

        public static IPlatform Platform { get { return Instance.Value.Platform; } }

        public static IDialogs Dialogs { get { return Instance.Value.Dialogs; } }
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
