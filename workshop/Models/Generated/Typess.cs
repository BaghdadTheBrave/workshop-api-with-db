using System;
using System.Collections.Generic;

namespace worksop.Models
{
    public partial class Typess
    {
        public Typess()
        {
            Products = new HashSet<Product>();
        }

        public int IdTypess { get; set; }
        public string? NameTypess { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
