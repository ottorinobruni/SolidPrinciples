using System;
namespace DeviceInfo
{
    public class MobileDeviceReviewer : Reviewer
    {
        public MobileDeviceReviewer(DeviceService service)
            : base(service)
        {
        }

        public override void Evaluate(Device device)
        {
            Log.WriteLine("Evaluating Mobile device...");
            if (String.IsNullOrEmpty(device.Sim))
            {
                Log.WriteLine("Mobile data must specify Sim!");
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
