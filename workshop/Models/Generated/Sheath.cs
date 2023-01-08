using System;
using System.Collections.Generic;

namespace worksop.Models
{
    public partial class Sheath
    {
        public Sheath()
        {
            Products = new HashSet<Product>();
        }

        public int IdSheaths { get; set; }
        public int? WeightSheaths { get; set; }
        public int? IdFixingSheaths { get; set; }
        public int? IdMaterialSheaths { get; set; }

        public virtual Fixings4? IdFixingSheathsNavigation { get; set; }
        public virtual Material? IdMaterialSheathsNavigation { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
