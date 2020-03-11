using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthenticationWEBAPI.Models
{
    public class VehiclePushAnalysis
    {
        public string Vin { get; set; }

        public string Departure { get; set; }

        public string Destination { get; set; }

        public List<Break> RefuelStops { get; set; }

        public float Consumption { get; set; }

        public List<Break> Breaks { get; set; }
    }
}