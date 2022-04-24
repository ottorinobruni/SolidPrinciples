using System;
namespace DeviceInfo
{
    public class MobileDeviceReviewer : Reviewer
    {
        public MobileDeviceReviewer(DeviceService service, ConsoleLog log)
            : base(service, log)
        {
        }

        public override void Evaluate(Device device)
        {
            log.WriteLine("Evaluating Mobile device...");
            if (String.IsNullOrEmpty(device.Sim))
            {
                log.WriteLine("Mobile data must specify Sim!");
                return;
            }

            if (device.Manufacturer.Equals("Apple"))
            {
                service.Rating = 8;
            }
            else
            {
                service.Rating = 6;
            }

            if (device.Sim.Equals("Dual SIM"))
            {
                service.Rating++;
            }
        }
    }
}
