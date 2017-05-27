using System;
namespace EifelMono.KaOS
{
    public interface IDialogs : IAvailable
    {
        string OpenFileDialog(string path, string[] extensions= null);

        MessageBoxButton MessageBox(string title, string message, MessageBoxButton[] buttons);
    }
}
