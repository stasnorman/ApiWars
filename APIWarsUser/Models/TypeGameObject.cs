using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class TypeGameObject
    {
        public TypeGameObject()
        {
            GameObjects = new HashSet<GameObject>();
        }

        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string UnicEfficensyId { get; set; } = null!;

        public virtual UnicEfficiency UnicEfficensy { get; set; } = null!;
        public virtual ICollection<GameObject> GameObjects { get; set; }
    }
}
