using System;
using System.Collections.Generic;

namespace worksop.Models
{
    public partial class Fixings4
    {
        public Fixings4()
        {
            Sheaths = new HashSet<Sheath>();
        }

        public int IdFixings4s { get; set; }
        public string? NameFixings4s { get; set; }

        public virtual ICollection<Sheath> Sheaths { get; set; }
    }
}
