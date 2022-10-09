namespace DeviceInfo
{
    public class UnknownDeviceReviewer : Reviewer
    {
        public UnknownDeviceReviewer(DeviceService service)
            : base(service)
        {
        }

        public override void Evaluate(Device device)
        {
            Log.WriteLine("Unknown Device Type");
        }
    }
}