using System;
namespace DeviceInfo
{
    public abstract class Reviewer
    {
        protected readonly DeviceService service;
        protected readonly ConsoleLog log;

        public Reviewer(DeviceService service, ConsoleLog log)
        {
            this.service = service;
            this.log = log;
        }

        public abstract void Evaluate(Device device);
    }
}
