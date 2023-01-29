namespace DeviceInfo
{
    /// <summary>
    /// The DeviceService reads the device data details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class DeviceService
    {
        private readonly ILog log;
        private readonly IFileDataSource dataSource;
        private readonly IJsonDataSerializer deviceSerializer;
        private decimal rating = 0;

        public DeviceService(ILog log, IFileDataSource dataSource, IJsonDataSerializer deviceSerializer)
        {
            this.log = log;
            this.dataSource = dataSource;
            this.deviceSerializer = deviceSerializer;
        }

        public void Evaluate()
        {
            string dataJson = dataSource.GetDeviceFromSource();

            var device = deviceSerializer.GetDeviceFromJsonString(dataJson);

            var factory = new ReviewerFactory(this.log);

            var reviewer = factory.Create(device);
            rating = reviewer.Evaluate(device);

            log.WriteLine("Evaluation completed.");
        }

        public bool IsBestBuy()
        {
            return (rating >= 9);
        }
    }
}