using System;
using EifelMono.Core;
using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;
using Foundation;
using UIKit;

[assembly: BackDoor(typeof(EifelMono.KaOS.iOS.Application))]
namespace EifelMono.KaOS.iOS
{
    public class Application : ApplicationCore
    {
        public override bool IsAvailable { get => true; }

        public override string Name
        {
            get
            {
                return Config("CFBundleDisplayName");
            }
        }

        public override string Version
        {
            get
            {
                return Config("CFBundleShortVersionString");
            }
        }

        public override string Build
        {
            get
            {
                return Config("CFBundleVersion");
            }
        }

        protected string Config(string key)
        {
            try
            {
                return NSBundle.MainBundle.ObjectForInfoDictionary(key).ToString();
            }
            catch
            {
                return "";
            }
        }

        private First BadgeRegister = new First();

        private void RegisterBadge()
        {
            if (BadgeRegister.IsFirst)
            {
                var settings = UIUserNotificationSettings.GetSettingsForTypes(
                     UIUserNotificationType.Badge,
                     new NSSet());
                UIApplication.SharedApplication.RegisterUserNotificationSettings(settings);
            }
        }

        public override int Badge
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

        private First<StatusBarStyleKind> _StatusBarStyle = new First<StatusBarStyleKind>(StatusBarStyleKind.Normal);

        public override StatusBarStyleKind StatusBarStyle { get => _StatusBarStyle.Value; set => SetStatusBarStyle(value, false); }

        public override void SetStatusBarStyle(StatusBarStyleKind statusBarStyle, bool animated)
        {
            if (_StatusBarStyle.IsFirstOrChanged(statusBarStyle))
                switch (statusBarStyle)
                {
                    case StatusBarStyleKind.Normal:
                        UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.Default, animated);
                        break;
                    case StatusBarStyleKind.Light:
                        UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, animated);
                        break;
                    case StatusBarStyleKind.Dark:
                        UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.BlackOpaque, animated);
                        break;
                    case StatusBarStyleKind.Translucent:
                        UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.BlackTranslucent, animated);
                        break;
                }
        }

        private First<VisibilityKind> _SetStatusBarVisibility = new First<VisibilityKind>(VisibilityKind.Visible);

        public override VisibilityKind StatusBarVisibility { get => _SetStatusBarVisibility.Value; set => SetStatusBarVisibility(value, false); }

        public override void SetStatusBarVisibility(VisibilityKind visibility, bool animated)
        {
            if (_SetStatusBarVisibility.IsFirstOrChanged(visibility))
                switch (visibility)
                {
                    case VisibilityKind.Visible:
                        UIApplication.SharedApplication.SetStatusBarHidden(false, animated);
                        break;
                    case VisibilityKind.Hidden:
                        UIApplication.SharedApplication.SetStatusBarHidden(true, animated); UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, animated);
                        break;
                    case VisibilityKind.Disabled:
                        break;
                }
        }
    }
}