using System;
namespace DeviceInfo
{
    public class DesktopDeviceReviewer : Reviewer
    {
        public DesktopDeviceReviewer(ILog log)
            : base(log)
        {
        }

        public override decimal Evaluate(Device device)
        {
            log.WriteLine("Evaluating Desktop device...");
            if (String.IsNullOrEmpty(device.Monitor))
            {
                log.WriteLine("Desktop data must specify Monitor!");
                return 0;
            }

            if (device.Manufacturer.Equals("Apple"))
            {
                Rating = 9;
            }
            else
            {
                Rating = 7;
            }

            if (device.Monitor.Equals("34-inch"))
            {
                Rating++;
            }
            else
            {
                Rating--;
            }
            return Rating;
        }
    }
}
