using System;

namespace DeviceInfo
{
    /// <summary>
    /// The DeviceService reads the device data details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class DeviceService
    {
        public ConsoleLog Log { get; set; } = new ConsoleLog();
        public FileDataSource DataSource { get; set; } = new FileDataSource();
        public JsonDataSerializer DeviceSerializer { get; set; } = new JsonDataSerializer();
        public decimal Rating { get; set; } = 0;
        
        public void Evaluate()
        {
            string dataJson = DataSource.GetDeviceFromSource();

            var device = DeviceSerializer.GetDeviceFromJsonString(dataJson);

            switch (device.Type)
            {
                case DeviceType.Mobile:
                    Log.WriteLine("Evaluating Mobile device...");
                    if (String.IsNullOrEmpty(device.Sim))
                    {
                        Log.WriteLine("Mobile data must specify Sim!");
                        return;
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

                    break;
                case DeviceType.Tablet:
                    Log.WriteLine("Evaluating Tablet device...");
                    if (String.IsNullOrEmpty(device.Pencil))
                    {
                        Log.WriteLine("Tablet data must specify Pencil!");
                        return;
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
                    break;
                case DeviceType.Desktop:
                    Log.WriteLine("Evaluating Desktop device...");
                    if (String.IsNullOrEmpty(device.Monitor))
                    {
                        Log.WriteLine("Desktop data must specify Monitor!");
                        return;
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
                    break;
                default:
                    Log.WriteLine("Unknown Device type");
                    break;
            }

            Log.WriteLine("Evaluation completed.");
        }

        public bool IsBestBuy()
        {
            return (Rating >= 9);
        }
    }
}