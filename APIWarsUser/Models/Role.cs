using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class Role
    {
        public Role()
        {
            Accounts = new HashSet<Account>();
        }

        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Symbol { get; set; } = null!;

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
