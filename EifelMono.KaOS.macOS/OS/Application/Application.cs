using System;

namespace EifelMono.KaOS.Implementation.OSx
{
    public partial class Application : IApplication
    {
        public bool IsAvailable => true;

        protected int _Badge;
        public int Badge { get => _Badge; set => _Badge = value; }


        private Checker<StatusBarStyle> _StatusBarStyle = new Checker<StatusBarStyle>(StatusBarStyle.Normal);

        public StatusBarStyle StatusBarStyle { get => _StatusBarStyle.Value; set => SetStatusBarStyle(value, false); }

        public void SetStatusBarStyle(StatusBarStyle statusBarStyle, bool animated)
        {
            OS.Developer.NotImplemented();
        }

        private Checker<Visibility> _SetStatusBarVisibility = new Checker<Visibility>(Visibility.Visible);

        public Visibility StatusBarVisibility { get => _SetStatusBarVisibility.Value; set => SetStatusBarVisibility(value, false); }

        public void SetStatusBarVisibility(Visibility visibility, bool animated)
        {
            OS.Developer.NotImplemented();
        }
    }
}
