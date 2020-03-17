using BasicAuthenticationWEBAPI.Models;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Xml.Serialization;

namespace BasicAuthenticationWEBAPI.Controllers
{
    public class VehicleController : ApiController
    {
        private const string myKey = "?o=xml&key=AgvDvPMqLv89yTjPGtTu1WKimh52ITg8HlSmox_XIaSmH-R2SJL0JxDVCg0zwnDh";
        private const string path = "http://dev.virtualearth.net/REST/v1/Locations/";

        [BasicAuthentication]
        [HttpGet]
        [Route("v1/Trips/")]
        public async Task<HttpResponseMessage> Trips(VehiclePush vehiclePush)
        {
            //string username = Thread.CurrentPrincipal.Identity.Name;
            //if (username.ToLower() != "maleuser" && username.ToLower() != "femaleuser") return Request.CreateResponse(HttpStatusCode.BadRequest);

            if (vehiclePush == null) return null;

            VehiclePushAnalysis vehiclePushAnalysis = new VehiclePushAnalysis() { Vin = vehiclePush?.Vin };
            List<VehiclePushDataPoint> dataPoints = vehiclePush.Data;

            //sollte mindestens <2 Elemente haben, denn es ist eine Reise
            if (dataPoints.Count < 1) return null;

            var firstDataPoint = dataPoints[0];
            var lastDataPoint = dataPoints[dataPoints.Count - 1];


            Response bingResponse = null;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string pathOrigin = path + firstDataPoint?.PositionLat.ToString(CultureInfo.InvariantCulture) + "," + firstDataPoint?.PositionLong.ToString(CultureInfo.InvariantCulture) + myKey;
                    HttpResponseMessage response = await client.GetAsync(pathOrigin);

                    XmlSerializer serializer = new XmlSerializer(typeof(Response));
                    if (response.IsSuccessStatusCode)
                    {
                        var responseString = await response.Content.ReadAsStringAsync();
                        StringReader rdr = new StringReader(responseString);
                        bingResponse = (Response)serializer.Deserialize(rdr);

                        vehiclePushAnalysis.Departure = bingResponse?.ResourceSets?.ResourceSet?.Resources?.Location?.Address?.Locality;
                    }


                    string pathDestination = path + lastDataPoint.PositionLat.ToString(CultureInfo.InvariantCulture) + "," + lastDataPoint.PositionLong.ToString(CultureInfo.InvariantCulture) + myKey;
                    response = await client.GetAsync(pathDestination);
                    if (response.IsSuccessStatusCode)
                    {
                        var responseString = await response.Content.ReadAsStringAsync();                        
                        StringReader rdr = new StringReader(responseString);
                        bingResponse = (Response)serializer.Deserialize(rdr);
                        vehiclePushAnalysis.Destination = bingResponse?.ResourceSets?.ResourceSet?.Resources?.Location?.Address?.Locality;
                    }
                }
                
                catch (System.Exception ex)
                {
                    throw;
                }
        }

        if (lastDataPoint.Odometer > firstDataPoint.Odometer)
        {
            //Per 100 km
            vehiclePushAnalysis.Consumption = System.Math.Abs( (firstDataPoint.FuelLevel - lastDataPoint.FuelLevel) * 100 / (lastDataPoint.Odometer - firstDataPoint.Odometer));
        }

        int previousFuelLevel = firstDataPoint.FuelLevel;
        int currentFuelLevel;
        List<Break> RefuelStops = new List<Break>();
        List<Break> Breaks = new List<Break>();

            foreach (var dataPoint in dataPoints)
            {
                currentFuelLevel = dataPoint.FuelLevel;

                Break br = new Break()
                {
                    StartTimestamp = dataPoint.Timestamp,
                    EndTimestamp = dataPoint.Timestamp,
                    PositionLat = dataPoint.PositionLat,
                    PositionLong = dataPoint.PositionLong
                };
                if (currentFuelLevel > previousFuelLevel + 1 )                                    
                    RefuelStops.Add(br);
                else
                {
                    Breaks.Add(br);
                }

                previousFuelLevel = currentFuelLevel;
            }

            vehiclePushAnalysis.RefuelStops = RefuelStops;
            vehiclePushAnalysis.Breaks = Breaks;

            return Request.CreateResponse(HttpStatusCode.OK, vehiclePushAnalysis);           
        }
    }
}
