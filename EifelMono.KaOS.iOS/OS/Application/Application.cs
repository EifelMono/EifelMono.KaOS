using System;
using UIKit;

namespace EifelMono.KaOS.Implementation.OSx
{
    public partial class Application : IApplication
    {
        public bool IsAvailable => true;

        public int Badge { get => (int)UIApplication.SharedApplication.ApplicationIconBadgeNumber; set => UIApplication.SharedApplication.ApplicationIconBadgeNumber = value; }
    }
}
