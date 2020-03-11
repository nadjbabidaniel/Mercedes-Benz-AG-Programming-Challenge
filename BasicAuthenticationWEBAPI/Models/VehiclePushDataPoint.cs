using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthenticationWEBAPI.Models
{
    public class VehiclePushDataPoint
    {
        public Int64 Timestamp { get; set; }

        public int Odometer { get; set; }

        public int FuelLevel { get; set; }

        public float PositionLat { get; set; }

        public float PositionLong { get; set; }
    }
}