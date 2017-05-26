using System;

namespace EifelMono.KaOS
{
    public interface IOS
    {

        ISystem System { get; }

        IPlatform Platform { get; }

        IDialogs Dialogs { get; }

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
