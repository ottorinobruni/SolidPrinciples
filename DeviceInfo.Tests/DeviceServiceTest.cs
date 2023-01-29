using System;
using System.IO;
using System.Text.Json;
using Xunit;

namespace DeviceInfo.Tests
{
    public class DeviceServiceTest
    {
        [Fact]
        public void Evaluate_WhenMobileAppleDualSim_DeviceShouldBeBestBuy()
        {
            // Setup
            var device = new Device
            {
                Type = DeviceType.Mobile,
                Manufacturer = "Apple",
                Price = 999,
                Sim = "Dual SIM"
            };
            string json = JsonSerializer.Serialize<Device>(device);
            File.WriteAllText("deviceData.json", json);
            var deviceService = new DeviceService(new ConsoleLog(), new FileDataSource(), new JsonDataSerializer());

            // Execute
            deviceService.Evaluate();
            
            // Assert
            var actual = deviceService.IsBestBuy();
            Assert.True(actual);
        }

        [Fact]
        public void Evaluate_WhenTabletNoPencil_DeviceShouldNotBeBestBuy()
        {
            // Setup
            var device = new Device
            {
                Type = DeviceType.Tablet,
                Manufacturer = "Samsung",
                Price = 699,
                Pencil = "S Pen"
            };
            string json = JsonSerializer.Serialize<Device>(device);
            File.WriteAllText("deviceData.json", json);
            var deviceService = new DeviceService(new ConsoleLog(), new FileDataSource(), new JsonDataSerializer());

            // Execute
            deviceService.Evaluate();

            // Assert
            var actual = deviceService.IsBestBuy();
            Assert.False(actual);
        }
    }
}
