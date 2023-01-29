namespace DeviceInfo
{
    public class UnknownDeviceReviewer : Reviewer
    {
        public UnknownDeviceReviewer(ILog log)
            : base(log)
        {
        }

        public override decimal Evaluate(Device device)
        {
            log.WriteLine("Unknown Device Type");
            return 0;
        }
    }
}