using System;
using System.Collections.Generic;

namespace worksop.Models
{
    public partial class Lock
    {
        public Lock()
        {
            Products = new HashSet<Product>();
        }

        public int IdLocks { get; set; }
        public string? NameLocks { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
