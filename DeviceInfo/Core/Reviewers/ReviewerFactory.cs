using System;
namespace DeviceInfo
{
    public class ReviewerFactory
    {
        private readonly ILog log;

        public ReviewerFactory(ILog log)
        {
            this.log = log;
        }

        public Reviewer Create(Device device)
        {
            switch (device.Type)
            {
                case DeviceType.Mobile:
                    return new MobileDeviceReviewer(log);
                case DeviceType.Tablet:
                    return new TabletDeviceReviewer(log);
                case DeviceType.Desktop:
                    return new DesktopDeviceReviewer(log);
                case DeviceType.IoT:
                    return new IoTDeviceReviewer(log);
                default:
                    return new UnknownDeviceReviewer(log);
            }
        }
    }
}
