using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class DisasterWorld
    {
        public DisasterWorld()
        {
            EventNews = new HashSet<EventNew>();
        }

        public string Name { get; set; } = null!;
        public string Body { get; set; } = null!;

        public virtual ICollection<EventNew> EventNews { get; set; }
    }
}
