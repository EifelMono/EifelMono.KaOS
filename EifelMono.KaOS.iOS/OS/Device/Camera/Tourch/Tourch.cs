using System;
using AVFoundation;
using Foundation;
using EifelMono.Core.Extensions;
using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;

[assembly: BackDoor(typeof(EifelMono.KaOS.iOS.Tourch))]
namespace EifelMono.KaOS.iOS
{
    public class Tourch : TourchCore
    {
        bool? _IsAvailable = null;

        public override bool IsAvailable
        {
            get
            {
                if (_IsAvailable == null)
                    using (AVCaptureDevice device = AVCaptureDevice.GetDefaultDevice(AVMediaType.Video))
                    {
                        _IsAvailable = device != null ? device.TorchAvailable : false;
                    }
                return _IsAvailable ?? false;
            }
        }

        public override bool Value
        {
            get
            {
                using (AVCaptureDevice device = AVCaptureDevice.GetDefaultDevice(AVMediaType.Video))
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
                using (AVCaptureDevice device = AVCaptureDevice.GetDefaultDevice(AVMediaType.Video))
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
                                Log.LogError($"LockForConfiguration out error={error}");
                        }
                    }
                }
            }
        }
    }
}