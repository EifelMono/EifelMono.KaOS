﻿using System;
using AudioToolbox;

namespace EifelMono.KaOS.Implementation.OSx
{
    public class Device : IDevice
    {
        public PlatformKind PlatformKind => PlatformKind.iOS;

        public bool IsAvailable => true;

        private Lazy<ICamera> _Camera = new Lazy<ICamera>(() => new Camera());

        public ICamera Camera => _Camera.Value;

        public void Vibrate(int time = -1)
        {
            SystemSound.Vibrate.PlaySystemSound();
        }
    }
}
