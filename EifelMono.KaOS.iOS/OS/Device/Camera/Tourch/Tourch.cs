using System;
using AVFoundation;
using Foundation;
using EifelMono.KaOS.Extensions;

namespace EifelMono.KaOS.Implementation.OSx
{
    public class Tourch : ITourch
    {
        bool? _IsAvailable = null;
        bool IAvailable.IsAvailable
        {
            get
            {
                if (_IsAvailable == null)
                    using (AVCaptureDevice device = AVCaptureDevice.DefaultDeviceWithMediaType(AVMediaType.Video))
                    {
                        _IsAvailable = device != null ? device.TorchAvailable : false;
                    }
                return _IsAvailable ?? false;
            }
        }

        public bool Value
        {
            get
            {
                using (AVCaptureDevice device = AVCaptureDevice.DefaultDeviceWithMediaType(AVMediaType.Video))
                {
                    if (device != null)
                    {
                        if (device.TorchAvailable)
                            return device.TorchMode == AVCaptureTorchMode.On;
                        else
                            return false;
                    }
                    else
                        return false;
                }
            }
            set
            {
                using (AVCaptureDevice device = AVCaptureDevice.DefaultDeviceWithMediaType(AVMediaType.Video))
                {
                    if (device != null)
                    {
                        if (device.TorchAvailable)
                        {
                            NSError error = null;
                            if (device.LockForConfiguration(out error))
                            {
                                device.TorchMode = value ? AVCaptureTorchMode.On : AVCaptureTorchMode.Off;
                                device.UnlockForConfiguration();
                            }
                            else
                                $"LockForConfiguration out error={error}".LogError();
                        }
                    }
                }
            }
        }
    }
}