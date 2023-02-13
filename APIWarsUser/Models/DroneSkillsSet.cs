using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class DroneSkillsSet
    {
        public string ShortNameDrone { get; set; } = null!;
        public string EfficiencyActionName { get; set; } = null!;
        public int? Timestamp { get; set; }

        public virtual EfficiencyAction EfficiencyActionNameNavigation { get; set; } = null!;
        public virtual Drone ShortNameDroneNavigation { get; set; } = null!;
    }
}
