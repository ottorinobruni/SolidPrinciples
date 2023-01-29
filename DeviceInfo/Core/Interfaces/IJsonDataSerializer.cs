using System;

namespace DeviceInfo
{
    public interface IJsonDataSerializer
    {
        Device GetDeviceFromJsonString(string jsonString);
    }
}

