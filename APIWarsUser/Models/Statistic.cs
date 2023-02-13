using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class Statistic
    {
        public string LoginUser { get; set; } = null!;
        public int Sac { get; set; }
        public int Slm { get; set; }
        public int Cem { get; set; }
        public int Cec { get; set; }
        public int Idle { get; set; }

        public virtual Account LoginUserNavigation { get; set; } = null!;
    }
}
