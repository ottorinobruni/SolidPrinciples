using System;

namespace DeviceInfo
{
    /// <summary>
    /// The DeviceService reads the device data details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class DeviceService
    {
        public ILog Log { get; set; } = new ConsoleLog();
        public FileDataSource DataSource { get; set; } = new FileDataSource();
        public JsonDataSerializer DeviceSerializer { get; set; } = new JsonDataSerializer();
        public decimal Rating { get; set; } = 0;
        
        public void Evaluate()
        {
            string dataJson = DataSource.GetDeviceFromSource();

            var device = DeviceSerializer.GetDeviceFromJsonString(dataJson);

            var factory = new ReviewerFactory();

            var reviewer = factory.Create(device, this);
            reviewer.Evaluate(device);

            Log.WriteLine("Evaluation completed.");
        }

        public bool IsBestBuy()
        {
            return (Rating >= 9);
        }
    }
}