using System;
namespace DeviceInfo
{
    public class DesktopDeviceReviewer : Reviewer
    {
        public DesktopDeviceReviewer(DeviceService service, ConsoleLog log)
            : base(service, log)
        {
        }

        public override void Evaluate(Device device)
        {
            log.WriteLine("Evaluating Desktop device...");
            if (String.IsNullOrEmpty(device.Monitor))
            {
                log.WriteLine("Desktop data must specify Monitor!");
                return;
            }

            if (device.Manufacturer.Equals("Apple"))
            {
                service.Rating = 9;
            }
            else
            {
                service.Rating = 7;
            }

            if (device.Monitor.Equals("34-inch"))
            {
                service.Rating++;
            }
            else
            {
                service.Rating--;
            }
        }
    }
}
