using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class Team
    {
        public Team()
        {
            DeveloperInTeams = new HashSet<DeveloperInTeam>();
        }

        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime DateCreate { get; set; }

        public virtual ICollection<DeveloperInTeam> DeveloperInTeams { get; set; }
    }
}
