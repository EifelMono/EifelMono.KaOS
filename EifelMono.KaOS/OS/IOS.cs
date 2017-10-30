using System;

namespace EifelMono.KaOS
{
    public interface IOS
    {
        IApplication Application { get; }

        IDevice Device { get; }

        IDialogs Dialogs { get; }
    }
}
