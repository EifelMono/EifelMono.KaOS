using System;

namespace EifelMono.KaOS.Implementation.OSx
{
    public partial class Application : IApplication
    {
        public bool IsAvailable => true;

        protected int _Badge;
        public int Badge { get => _Badge; set => _Badge = value; }
    }
}
