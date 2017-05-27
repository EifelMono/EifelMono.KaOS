using System;
namespace EifelMono.KaOS.Implementation.OSx
{
    public class Dialogs : IDialogs
    {
        public bool IsAvailable => true;

        public MessageBoxButton MessageBox(string title, string message, MessageBoxButton[] buttons)
        {
            OS.Developer.NoEquivalentFunctionAvailable(nameof(MessageBox));
            return MessageBoxButton.None;
        }

        public string OpenFileDialog(string path, string[] extensions)
        {
            OS.Developer.NoEquivalentFunctionAvailable(nameof(OpenFileDialog));
            return "";
        }
    }
}
