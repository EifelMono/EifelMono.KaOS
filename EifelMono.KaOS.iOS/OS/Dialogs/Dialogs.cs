using System;
using Foundation;
using UIKit;
using EifelMono.Core.Extensions;
using EifelMono.KaOS;
using System.Diagnostics;
using System.Threading.Tasks;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.iOS.Dialogs))]
namespace EifelMono.KaOS.iOS
{
    public class Dialogs : DialogsCore
    {
        public override bool IsAvailable => true;

        public override async void ActivityController(object obj, ActivityType activityType)
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
