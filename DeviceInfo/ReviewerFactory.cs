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
                    return new MobileDeviceReviewer(service);
                case DeviceType.Tablet:
                    return new TabletDeviceReviewer(service);
                case DeviceType.Desktop:
                    return new DesktopDeviceReviewer(service);
                case DeviceType.IoT:
                    return new IoTDeviceReviewer(service);
                default:
                    return new UnknownDeviceReviewer(service);
            }
        }
    }
}
