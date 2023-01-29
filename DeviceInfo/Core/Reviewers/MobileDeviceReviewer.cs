using System;
namespace DeviceInfo
{
    public class MobileDeviceReviewer : Reviewer
    {
        public MobileDeviceReviewer(ILog log)
            : base(log)
        {
        }

        public override decimal Evaluate(Device device)
        {
            log.WriteLine("Evaluating Mobile device...");
            if (String.IsNullOrEmpty(device.Sim))
            {
                log.WriteLine("Mobile data must specify Sim!");
                return 0;
            }

            if (device.Manufacturer.Equals("Apple"))
            {
                Rating = 8;
            }
            else
            {
                Rating = 6;
            }

            if (device.Sim.Equals("Dual SIM"))
            {
                Rating++;
            }

            return Rating;
        }
    }
}
