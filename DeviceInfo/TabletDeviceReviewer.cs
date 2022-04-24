using System;
namespace DeviceInfo
{
    public class TabletDeviceReviewer : Reviewer
    {
        public TabletDeviceReviewer(DeviceService service, ConsoleLog log)
            : base(service, log)
        {
        }

        public override void Evaluate(Device device)
        {
            log.WriteLine("Evaluating Tablet device...");
            if (String.IsNullOrEmpty(device.Pencil))
            {
                log.WriteLine("Tablet data must specify Pencil!");
                return;
            }

            if (device.Manufacturer.Equals("Apple"))
            {
                service.Rating = 9;
            }
            else
            {
                service.Rating = 5;
            }

            if (device.Pencil.Equals("Pencil 2"))
            {
                service.Rating++;
            }
        }
    }
}
