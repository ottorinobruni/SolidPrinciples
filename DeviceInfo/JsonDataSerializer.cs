using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DeviceInfo
{
    public interface IJsonDataSerializer
    {
        Device GetDeviceFromJsonString(string jsonString);
    }

    public class JsonDataSerializer : IJsonDataSerializer
    {
        public Device GetDeviceFromJsonString(string jsonString)
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            return JsonSerializer.Deserialize<Device>(jsonString, options);
        }
    }
}
