using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class EfficiencyAction
    {
        public EfficiencyAction()
        {
            DroneSkillsSets = new HashSet<DroneSkillsSet>();
        }

        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal ValueAction { get; set; }

        public virtual ICollection<DroneSkillsSet> DroneSkillsSets { get; set; }
    }
}
