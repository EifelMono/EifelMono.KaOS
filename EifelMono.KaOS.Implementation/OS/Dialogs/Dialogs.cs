using System;
namespace EifelMono.KaOS.Implementation.OS
{
    public class Dialogs: IDialogs
    {
        public bool IsAvailable => Implementation != null && Implementation.IsAvailable;

        public static IDialogs Implementation => new Lazy<IDialogs>(() => new OSx.Dialogs()).Value;

        public string OpenFileDialog(string path, string[] extensions = null)
        {
            return Implementation.OpenFileDialog(path, extensions);
        }
    }
}
