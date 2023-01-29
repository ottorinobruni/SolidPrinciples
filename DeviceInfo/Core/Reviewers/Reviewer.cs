using System;
namespace DeviceInfo
{
    public abstract class Reviewer
    {
        public readonly ILog log;
        public decimal Rating { get; set; } = 0;

        public Reviewer(ILog log)
        {
            this.log = log;
        }

        public abstract decimal Evaluate(Device device);
    }
}
