using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class GameObject
    {
        public GameObject()
        {
            NetScans = new HashSet<NetScan>();
            ObjectAvailables = new HashSet<ObjectAvailable>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string TypeObject { get; set; } = null!;
        public string Ipv6 { get; set; } = null!;
        public string StateObject { get; set; } = null!;
        public int? HeatPoint { get; set; }

        public virtual StateGameObject StateObjectNavigation { get; set; } = null!;
        public virtual TypeGameObject TypeObjectNavigation { get; set; } = null!;
        public virtual ICollection<NetScan> NetScans { get; set; }
        public virtual ICollection<ObjectAvailable> ObjectAvailables { get; set; }
    }
}
