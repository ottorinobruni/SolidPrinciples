using System;
namespace DeviceInfo
{
    public class TabletDeviceReviewer : Reviewer
    {
        public TabletDeviceReviewer(ILog log)
            : base(log)
        {
        }

        public override decimal Evaluate(Device device)
        {
            log.WriteLine("Evaluating Tablet device...");
            if (String.IsNullOrEmpty(device.Pencil))
            {
                log.WriteLine("Tablet data must specify Pencil!");
                return 0;
            }

            if (device.Manufacturer.Equals("Apple"))
            {
                Rating = 9;
            }
            else
            {
                Rating = 5;
            }

            if (device.Pencil.Equals("Pencil 2"))
            {
                Rating++;
            }

            return Rating;
        }
    }
}
