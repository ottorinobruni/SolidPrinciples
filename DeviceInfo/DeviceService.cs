using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DeviceInfo
{
    /// <summary>
    /// The DeviceService reads the device data details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class DeviceService
    {
        public decimal Rating { get; set; } = 0;
        
        public void Evaluate()
        {
            // load data - open file deviceData.json
            string dataJson = File.ReadAllText("deviceData.json");

            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            var device = JsonSerializer.Deserialize<Device>(dataJson, options);

            switch (device.Type)
            {
                case DeviceType.Mobile:
                    Console.WriteLine("Evaluating Mobile device...");
                    if (String.IsNullOrEmpty(device.Sim))
                    {
                        Console.WriteLine("Mobile data must specify Sim!");
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
                    Console.WriteLine("Evaluating Tablet device...");
                    if (String.IsNullOrEmpty(device.Pencil))
                    {
                        Console.WriteLine("Tablet data must specify Pencil!");
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
                    Console.WriteLine("Evaluating Desktop device...");
                    if (String.IsNullOrEmpty(device.Monitor))
                    {
                        Console.WriteLine("Desktop data must specify Monitor!");
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
                    Console.WriteLine("Unknown Device type");
                    break;
            }

            Console.WriteLine("Evaluation completed.");
        }

        public bool IsBestBuy()
        {
            return (Rating >= 9);
        }
    }
}