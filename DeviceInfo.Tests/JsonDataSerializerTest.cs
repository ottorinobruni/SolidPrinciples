using System;
using System.IO;
using System.Text.Json;
using Xunit;

namespace DeviceInfo.Tests
{
    public class JsonDataSerializerTest
    {
        [Fact]
        public void GetDeviceFromJsonString_WhenJsonTabletApple_DeviceShouldBeApple()
        {
            // Setup
            var inputJson = @"{
              ""Type"": ""Tablet"",
              ""Manufacturer"": ""Apple"",
              ""Price"": 599
            }";
            var serializer = new JsonDataSerializer();

            // Execute
            var expected = serializer.GetDeviceFromJsonString(inputJson);

            // Assert
            var actual = new Device { Type = DeviceType.Tablet, Manufacturer = "Apple" };
            Assert.Equal(expected.Manufacturer, actual.Manufacturer);
        }
    }
}
