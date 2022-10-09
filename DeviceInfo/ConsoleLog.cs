using System;
namespace DeviceInfo
{
    public interface ILog
    {
        void WriteLine(string message);
    }

    public class ConsoleLog : ILog
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
