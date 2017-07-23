using System;
using Foundation;
using UIKit;
using EifelMono.Core.Extensions;
using EifelMono.KaOS;
using System.Diagnostics;
using System.Threading.Tasks;

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

        public async void ActivityController(object obj, ActivityType activityType)
        {
            try
            {
                await Task.Delay(500);
                NSObject nsObject = null;
                try
                {
                    switch (activityType)
                    {
                        case ActivityType.Text:
                            {
                                var text = (string)obj;
                                nsObject = NSObject.FromObject(text);
                                break;
                            }
                        case ActivityType.Photo:
                            {
                                var img = UIImage.LoadFromData(NSData.FromArray((byte[])obj));
                                nsObject = NSObject.FromObject(img);
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    ex.LogException();
                    nsObject = null;
                }

                var activityItems = new[] { nsObject };
                var activityController = new UIActivityViewController(activityItems, null);

                var topController = UIApplication.SharedApplication.KeyWindow.RootViewController;

                while (topController.PresentedViewController != null)
                {
                    topController = topController.PresentedViewController;
                }

                topController.PresentViewController(activityController, true, () => { });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
