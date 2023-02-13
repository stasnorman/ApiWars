using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class EventNew
    {
        public EventNew()
        {
            NetScans = new HashSet<NetScan>();
        }

        public string CodeNumber { get; set; } = null!;
        public string Body { get; set; } = null!;
        public string? DisasterWorldName { get; set; }

        public virtual DisasterWorld? DisasterWorldNameNavigation { get; set; }
        public virtual ICollection<NetScan> NetScans { get; set; }
    }
}
