using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class ObjectAvailable
    {
        public long ServerId { get; set; }
        public string LoginUser { get; set; } = null!;
        public int ServerLevel { get; set; }

        public virtual Account LoginUserNavigation { get; set; } = null!;
        public virtual GameObject Server { get; set; } = null!;
    }
}
