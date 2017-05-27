﻿using System;
namespace EifelMono.KaOS.Implementation.OSx
{
    public class Device : IDevice
    {
        public PlatformKind PlatformKind => PlatformKind.FrameWork;

        public bool IsAvailable => true;

        private Lazy<ICamera> _Camera = new Lazy<ICamera>(() => new Camera());

        public ICamera Camera => _Camera.Value;

        public void Vibrate(int time = -1)
        {
            OS.Developer.NoEquivalentFunctionAvailable("");
        }
    }
}
