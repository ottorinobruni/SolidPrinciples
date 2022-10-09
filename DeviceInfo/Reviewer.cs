using System;
namespace DeviceInfo
{
    public abstract class Reviewer
    {
        protected readonly DeviceService service;
        protected ILog Log { get; set; } = new ConsoleLog();

        public Reviewer(DeviceService service)
        {
            this.service = service;
        }

        public abstract void Evaluate(Device device);
    }
}
