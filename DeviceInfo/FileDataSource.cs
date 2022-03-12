using System;
using System.IO;

namespace DeviceInfo
{
    public class FileDataSource
    {
        public string GetDeviceFromSource()
        {
            return File.ReadAllText("deviceData.json");
        }
    }
}
