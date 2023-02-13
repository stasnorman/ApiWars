using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class Account
    {
        public Account()
        {
            DeveloperInTeams = new HashSet<DeveloperInTeam>();
            InformationDrones = new HashSet<InformationDrone>();
            ObjectAvailables = new HashSet<ObjectAvailable>();
        }

        public string Login { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string RoleName { get; set; } = null!;
        public string ApiKey { get; set; } = null!;
        public int MaxRl { get; set; }

        public virtual Role RoleNameNavigation { get; set; } = null!;
        public virtual ICollection<DeveloperInTeam> DeveloperInTeams { get; set; }
        public virtual ICollection<InformationDrone> InformationDrones { get; set; }
        public virtual ICollection<ObjectAvailable> ObjectAvailables { get; set; }
    }
}
