using System;
namespace DeviceInfo
{
    public class ConsoleLog : ILog
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
