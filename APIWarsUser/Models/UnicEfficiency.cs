using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class UnicEfficiency
    {
        public UnicEfficiency()
        {
            TypeGameObjects = new HashSet<TypeGameObject>();
        }

        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public double? ValueAction { get; set; }

        public virtual ICollection<TypeGameObject> TypeGameObjects { get; set; }
    }
}
