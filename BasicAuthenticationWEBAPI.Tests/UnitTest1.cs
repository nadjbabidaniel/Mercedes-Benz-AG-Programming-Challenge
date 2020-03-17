using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using BasicAuthenticationWEBAPI.Controllers;
using BasicAuthenticationWEBAPI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicAuthenticationWEBAPI.Tests
{
    [TestClass]
    public class TestVehicle
    {
        [TestMethod]
        public async Task VehicleNotNull_Test()
        {
            VehiclePushDataPoint stuttgartPoint = new VehiclePushDataPoint()
            {
                Timestamp = 1559137020,
                Odometer = 7200,
                FuelLevel = 52,
                PositionLat = (float) 48.771990,
                PositionLong = (float) 9.172787
            };

            VehiclePushDataPoint munchenPoint = new VehiclePushDataPoint()
            {
                Timestamp = 1559137020,
                Odometer = 7300,
                FuelLevel = 54,
                PositionLat = (float)48.137154,
                PositionLong = (float)11.576124
            };

            VehiclePush vehiclePush = new VehiclePush()
            {
                BreakThreshold = 80,
                GasTankSize = 1800,
                Vin = "WDD1671591Z000999",
                Data = new System.Collections.Generic.List<VehiclePushDataPoint>()
                {
                    stuttgartPoint,
                    munchenPoint
                }
            };
          
            // Arrange
            var controller = new VehicleController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            // Act
            var response = await controller.Trips(vehiclePush);

            // Assert
            VehiclePushAnalysis pushAnalysis;
            Assert.IsTrue(response.TryGetContentValue<VehiclePushAnalysis>(out pushAnalysis));
            Assert.IsNotNull(pushAnalysis);           
        }
    }
}
