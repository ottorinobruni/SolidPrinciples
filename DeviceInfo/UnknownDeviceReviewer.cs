namespace DeviceInfo
{
    public class UnknownDeviceReviewer : Reviewer
    {
        public UnknownDeviceReviewer(DeviceService service, ConsoleLog log)
            : base(service, log)
        {
        }

        public override void Evaluate(Device device)
        {
            log.WriteLine("Unknown Device Type");
        }
    }
}