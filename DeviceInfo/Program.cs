using System;

namespace DeviceInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Device Info");

            var deviceService = new DeviceService();
            deviceService.Evaluate();

            if (deviceService.IsBestBuy())
            {
                Console.WriteLine($"Congratulation! This is a Best Buy: {deviceService.Rating}");
            }
            else
            {
                Console.WriteLine("This Device is not a Best Buy.");
            }
            Console.WriteLine("Stop Device Info");
        }
    }
}
