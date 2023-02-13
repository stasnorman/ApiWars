using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class InformationDrone
    {
        public long Id { get; set; }
        public long X { get; set; }
        public long Y { get; set; }
        public string Ipv6 { get; set; } = null!;
        public string DroneShortName { get; set; } = null!;
        public decimal? HeatPoint { get; set; }
        public string LoginUser { get; set; } = null!;
        public string? DroneNameUser { get; set; }

        public virtual Drone DroneShortNameNavigation { get; set; } = null!;
        public virtual Account LoginUserNavigation { get; set; } = null!;
    }
}
