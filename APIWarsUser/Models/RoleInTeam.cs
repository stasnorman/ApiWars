using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class RoleInTeam
    {
        public RoleInTeam()
        {
            DeveloperInTeams = new HashSet<DeveloperInTeam>();
        }

        public string Name { get; set; } = null!;

        public virtual ICollection<DeveloperInTeam> DeveloperInTeams { get; set; }
    }
}
