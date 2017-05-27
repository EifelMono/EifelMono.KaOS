using System;
using Foundation;
using UIKit;

namespace EifelMono.KaOS.Implementation.OSx
{
    public partial class Application : IApplication
    {
        public bool IsAvailable => true;

        private First IsRegisterBadge = new First();
        private void RegisterBadge()
        {
            if (IsRegisterBadge.IsFirst)
            {
                var settings = UIUserNotificationSettings.GetSettingsForTypes(
                     UIUserNotificationType.Badge,
                     new NSSet());
                UIApplication.SharedApplication.RegisterUserNotificationSettings(settings);
            }
        }

        public int Badge
        {
            get
            {
                return (int)UIApplication.SharedApplication.ApplicationIconBadgeNumber;
            }
            set
            {
                RegisterBadge();
                UIApplication.SharedApplication.ApplicationIconBadgeNumber = value;
            }
        }
    }
}
