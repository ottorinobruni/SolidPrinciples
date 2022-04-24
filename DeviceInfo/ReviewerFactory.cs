using System;
namespace DeviceInfo
{
    public class ReviewerFactory
    {
        public Reviewer Create(Device device, DeviceService service)
        {
            switch (device.Type)
            {
                case DeviceType.Mobile:
                    return new MobileDeviceReviewer(service, service.Log);
                case DeviceType.Tablet:
                    return new TabletDeviceReviewer(service, service.Log);
                case DeviceType.Desktop:
                    return new DesktopDeviceReviewer(service, service.Log);
                case DeviceType.IoT:
                    return new IoTDeviceReviewer(service, service.Log);
                default:
                    return new UnknownDeviceReviewer(service, service.Log);
            }
        }
    }
}
