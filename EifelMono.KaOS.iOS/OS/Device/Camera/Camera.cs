using System;
using System.Collections.Generic;
using UIKit;

namespace EifelMono.KaOS.Implementation.OSx
{
    public class Camera : ICamera
    {
        public bool IsAvailable => true;

        private Lazy<ITourch> _Tourch = new Lazy<ITourch>(() => new Tourch());

        public ITourch Tourch => _Tourch.Value;

        public List<CameraKind> AvailableCameras()
        {
            List<CameraKind> availableCameras = new List<CameraKind>();
            if (UIImagePickerController.IsCameraDeviceAvailable(UIImagePickerControllerCameraDevice.Front))
                availableCameras.Add(CameraKind.Front);
            if (UIImagePickerController.IsCameraDeviceAvailable(UIImagePickerControllerCameraDevice.Rear))
                availableCameras.Add(CameraKind.Rear);
            return availableCameras;
        }
    }
}
