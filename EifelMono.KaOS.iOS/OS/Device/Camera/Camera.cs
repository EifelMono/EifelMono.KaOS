using System;
using System.Collections.Generic;
using UIKit;

namespace EifelMono.KaOS.Implementation.OSx
{
    public class Camera : ICamera
    {
        public bool IsAvailable => true;

        public ITourch Tourch => new Lazy<ITourch>(() => new Tourch()).Value;

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
