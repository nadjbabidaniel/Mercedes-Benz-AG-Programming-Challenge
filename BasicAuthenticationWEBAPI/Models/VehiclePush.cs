using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthenticationWEBAPI.Models
{
    public class VehiclePush
    {
        public string Vin { get; set; }

        public int BreakThreshold { get; set; }

        public int GasTankSize { get; set; }

        public List<VehiclePushDataPoint> Data { get; set; }
    }
}