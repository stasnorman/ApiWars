using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class RateLimit
    {
        public string? Login { get; set; }
        public DateTime? Date { get; set; }
        public string? ActionUserName { get; set; }

        public virtual ActionUser? ActionUserNameNavigation { get; set; }
        public virtual Account? LoginNavigation { get; set; }
    }
}
