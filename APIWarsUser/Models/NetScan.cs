using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class NetScan
    {
        public long Id { get; set; }
        public long X { get; set; }
        public long Y { get; set; }
        public long GameObjectId { get; set; }
        public string EventNewCodeNumber { get; set; } = null!;
        public string PlanetName { get; set; } = null!;

        public virtual EventNew EventNewCodeNumberNavigation { get; set; } = null!;
        public virtual GameObject GameObject { get; set; } = null!;
        public virtual Planet PlanetNameNavigation { get; set; } = null!;
    }
}
