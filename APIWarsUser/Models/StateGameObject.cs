using System;
using System.Collections.Generic;

namespace APIWarsUser.Models
{
    public partial class StateGameObject
    {
        public StateGameObject()
        {
            GameObjects = new HashSet<GameObject>();
        }

        public string Name { get; set; } = null!;
        public string? SymbolState { get; set; }

        public virtual ICollection<GameObject> GameObjects { get; set; }
    }
}
