using System;
using System.Collections.Generic;

namespace worksop.Models
{
    public partial class Material
    {
        public Material()
        {
            Sheaths = new HashSet<Sheath>();
        }

        public int IdMaterials { get; set; }
        public string? NameMaterials { get; set; }

        public virtual ICollection<Sheath> Sheaths { get; set; }
    }
}
