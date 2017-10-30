using System;
using System.Collections.Generic;
using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;
using UIKit;

[assembly: BackDoor(typeof(EifelMono.KaOS.iOS.Camera))]
namespace EifelMono.KaOS.iOS
{
    public class Camera : CameraCore
    {
        public override bool IsAvailable => true;

        public override List<CameraKind> AvailableCameras()
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
