using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class DroneRole
    {
        public DroneRole()
        {
            Drones = new HashSet<Drone>();
        }

        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Drone> Drones { get; set; }
    }
}
