using System;
using System.IO;

namespace DeviceInfo
{
    public interface IFileDataSource
    {
        string GetDeviceFromSource();
    }

    public class FileDataSource : IFileDataSource
    {
        public string GetDeviceFromSource()
        {
            return File.ReadAllText("deviceData.json");
        }
    }
}
