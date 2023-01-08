using System;
using System.Collections.Generic;

namespace worksop.Models
{
    public partial class Opening
    {
        public Opening()
        {
            Products = new HashSet<Product>();
        }

        public int IdOpenings { get; set; }
        public string? NameOpenings { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
