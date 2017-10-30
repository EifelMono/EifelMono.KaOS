using System;
namespace EifelMono.KaOS.Implementation
{
    public class DialogsCore : IDialogs
    {
        public virtual bool IsAvailable => throw new NotImplementedException();

        public virtual void ActivityController(object obj, ActivityType activityType)
        {
            throw new NotImplementedException();
        }

        public virtual MessageBoxButton MessageBox(string title, string message, MessageBoxButton[] buttons)
        {
            throw new NotImplementedException();
        }

        public virtual string OpenFileDialog(string path, string[] extensions = null)
        {
            throw new NotImplementedException();
        }
    }
}
