using System;

namespace DeviceInfo
{
    /// <summary>
    /// The DeviceService reads the device data details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class DeviceService
    {
        private readonly ILog log;
        public FileDataSource DataSource { get; set; } = new FileDataSource();
        public JsonDataSerializer DeviceSerializer { get; set; } = new JsonDataSerializer();
        public decimal Rating { get; set; } = 0;

        public DeviceService(ILog log)
        {
            this.log = log;
        }

        public void Evaluate()
        {
            string dataJson = DataSource.GetDeviceFromSource();

            var device = DeviceSerializer.GetDeviceFromJsonString(dataJson);

            var factory = new ReviewerFactory();

            var reviewer = factory.Create(device, this);
            reviewer.Evaluate(device);

            log.WriteLine("Evaluation completed.");
        }

        public bool IsBestBuy()
        {
            return (Rating >= 9);
        }
    }
}