using System;

namespace DeviceInfo
{
    internal class IoTDeviceReviewer : Reviewer
    {
        public IoTDeviceReviewer(ILog log)
            : base(log)
        {
        }

        public override decimal Evaluate(Device device)
        {
            log.WriteLine("Evaluating IoT device...");
            if (String.IsNullOrEmpty(device.VoiceControl))
            {
                log.WriteLine("IoT data must specify VoiceControl!");
                return 0;
            }

            if (device.Manufacturer.Equals("Amazon"))
            {
                Rating = 8;
            }
            else if (device.Manufacturer.Equals("Apple"))
            {
                Rating = 9;
            }
            else
            {
                Rating = 7;
            }

            if (device.VoiceControl.Equals("true"))
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