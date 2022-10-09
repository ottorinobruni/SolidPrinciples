using System;
namespace DeviceInfo
{
    public class DesktopDeviceReviewer : Reviewer
    {
        public DesktopDeviceReviewer(DeviceService service)
            : base(service)
        {
        }

        public override void Evaluate(Device device)
        {
            Log.WriteLine("Evaluating Desktop device...");
            if (String.IsNullOrEmpty(device.Monitor))
            {
                Log.WriteLine("Desktop data must specify Monitor!");
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
