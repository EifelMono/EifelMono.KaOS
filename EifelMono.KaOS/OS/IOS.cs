using System;

namespace EifelMono.KaOS
{
    public interface IOS
    {
        IApplication Application { get; }

        IDevice Device { get; }

        IDialogs Dialogs { get; }

        ISystem System { get; }

        /*
        IApplication Application { get; }

        ICamera Camera { get; }

        IConnection Connection { get; }

        IDetails Details { get; }

        IDevice Device { get; }

        IMedia Media { get; }

        INotification Notification { get; }

        IUI UI { get; }

        IPhone Phone { get; }
        */
    }
}
