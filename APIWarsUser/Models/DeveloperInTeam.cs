using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class DeveloperInTeam
    {
        public string LoginUser { get; set; } = null!;
        public string TeamName { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string TokenTeam { get; set; } = null!;
        public int TimeSpanTokenEnd { get; set; }

        public virtual Account LoginUserNavigation { get; set; } = null!;
        public virtual RoleInTeam RoleNavigation { get; set; } = null!;
        public virtual Team TeamNameNavigation { get; set; } = null!;
    }
}
