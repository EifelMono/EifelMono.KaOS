using System;
namespace EifelMono.KaOS
{
    public interface IApplication: IAvailable
    {
        int Badge { get; set; }

        string ExecutionFileName { get; }

        void SetStatusBarStyle(StatusBarStyle statusBarStyle, bool animated);

        StatusBarStyle StatusBarStyle { get; set; }

        void SetStatusBarVisibility(Visibility visibility, bool animated);

        Visibility StatusBarVisibility { get; set; }

    }
}
