using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthenticationWEBAPI.Models
{
    public class Break
    {
        public Int64 StartTimestamp { get; set; }

        public Int64 EndTimestamp { get; set; }

        public float PositionLat { get; set; }

        public float PositionLong { get; set; }

    }
}