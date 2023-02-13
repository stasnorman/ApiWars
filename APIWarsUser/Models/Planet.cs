using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class Planet
    {
        public Planet()
        {
            NetScans = new HashSet<NetScan>();
        }

        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Square { get; set; } = null!;
        public int Latitude { get; set; }
        public int Longitude { get; set; }

        public virtual ICollection<NetScan> NetScans { get; set; }
    }
}
