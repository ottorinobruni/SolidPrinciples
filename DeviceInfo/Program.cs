using System;

namespace DeviceInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Device Info");

            var deviceService = new DeviceService(new ConsoleLog(), new FileDataSource(), new JsonDataSerializer());
            deviceService.Evaluate();

            if (deviceService.IsBestBuy())
            {
                Console.WriteLine($"Congratulation! This is a Best Buy!");
            }
            else
            {
                Console.WriteLine("This Device is not a Best Buy.");
            }
            Console.WriteLine("Stop Device Info");
        }
    }
}
