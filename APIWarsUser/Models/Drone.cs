using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class Drone
    {
        public Drone()
        {
            DroneSkillsSets = new HashSet<DroneSkillsSet>();
            InformationDrones = new HashSet<InformationDrone>();
        }

        public string ShortName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int MoveAction { get; set; }
        public string? DroneRoleName { get; set; }

        public virtual DroneRole? DroneRoleNameNavigation { get; set; }
        public virtual ICollection<DroneSkillsSet> DroneSkillsSets { get; set; }
        public virtual ICollection<InformationDrone> InformationDrones { get; set; }
    }
}
