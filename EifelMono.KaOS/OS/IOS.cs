using System;

namespace EifelMono.KaOS
{
    public interface IOS
    {
        PlatformKind Platform { get; }

        IApplication Application { get; }

        IDevice Device { get; }

        IDialogs Dialogs { get; }
    }
}
