using System;
namespace EifelMono.KaOS
{
    public interface IApplication: IAvailable
    {
        int Badge { get; set; }

        string Name { get; }

        Version AssemblyVersion { get; }

        string Version { get; }

        string Build { get; }

        string ExecutionFileName { get; }

        void SetStatusBarStyle(StatusBarStyleKind statusBarStyle, bool animated);

        StatusBarStyleKind StatusBarStyle { get; set; }

        /// <summary>
        /// Sets the status bar visibility.<br /> 
        /// <br /> 
        /// iOS: Need aditional values in info.plist<br /> 
        ///      "View controller-based status bar appearance" = "No"<br /> 
        /// </summary>
        /// <param name="visibility">Visibility.</param>
        /// <param name="animated">If set to <c>true</c> animated.</param>

        void SetStatusBarVisibility(VisibilityKind visibility, bool animated);

        VisibilityKind StatusBarVisibility { get; set; }
    }
}
