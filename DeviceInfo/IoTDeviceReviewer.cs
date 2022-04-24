using System;

namespace DeviceInfo
{
    internal class IoTDeviceReviewer : Reviewer
    {
        public IoTDeviceReviewer(DeviceService service, ConsoleLog log)
            : base(service, log)
        {
        }

        public override void Evaluate(Device device)
        {
            log.WriteLine("Evaluating IoT device...");
            if (String.IsNullOrEmpty(device.VoiceControl))
            {
                log.WriteLine("IoT data must specify VoiceControl!");
                return;
            }

            if (device.Manufacturer.Equals("Amazon"))
            {
                service.Rating = 8;
            }
            else if (device.Manufacturer.Equals("Apple"))
            {
                service.Rating = 9;
            }
            else
            {
                service.Rating = 7;
            }

            if (device.VoiceControl.Equals("true"))
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