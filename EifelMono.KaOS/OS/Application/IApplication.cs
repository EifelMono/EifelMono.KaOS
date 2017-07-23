using System;
namespace EifelMono.KaOS
{
    public interface IApplication: IAvailable
    {
        int Badge { get; set; }

        string Name { get; }

        string Version { get; }

        string Build { get; }

        string ExecutionFileName { get; }

        void SetStatusBarStyle(StatusBarStyle statusBarStyle, bool animated);

        StatusBarStyle StatusBarStyle { get; set; }

        /// <summary>
        /// Sets the status bar visibility.<br /> 
        /// <br /> 
        /// iOS: Need aditional values in info.plist<br /> 
        ///      "View controller-based status bar appearance" = "No"<br /> 
        /// </summary>
        /// <param name="visibility">Visibility.</param>
        /// <param name="animated">If set to <c>true</c> animated.</param>

        void SetStatusBarVisibility(Visibility visibility, bool animated);

        Visibility StatusBarVisibility { get; set; }

    }
}
