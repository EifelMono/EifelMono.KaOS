using System;
namespace EifelMono.KaOS.Implementation
{
    public class Dialogs: IDialogs
    {
        public bool IsAvailable => OSxDialogs != null && OSxDialogs.IsAvailable;

        public static IDialogs OSxDialogs => new Lazy<IDialogs>(() => new OSx.Dialogs()).Value;

        public MessageBoxButton MessageBox(string title, string message, MessageBoxButton[] buttons)
        {
            return OSxDialogs.MessageBox(title, message, buttons);
        }

        public string OpenFileDialog(string path, string[] extensions = null)
        {
            return OSxDialogs.OpenFileDialog(path, extensions);
        }

    }
}
