using System;
using System.Collections.Generic;

namespace worksop.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int IdProducts { get; set; }
        public string? NameProducts { get; set; }
        public int? WeightProducts { get; set; }
        public int? LengthProducts { get; set; }
        public int? IdWorkSurProducts { get; set; }
        public int? IdFurnitureProducts { get; set; }
        public int? IdSheathProducts { get; set; }
        public int? IdCrftsmnProducts { get; set; }
        public int? IdTypeProducts { get; set; }
        public int? IdLockProducts { get; set; }
        public int? IdFixingProducts { get; set; }
        public int? IdOpeningProducts { get; set; }

        public virtual Craftsman? IdCrftsmnProductsNavigation { get; set; }
        public virtual Fixing? IdFixingProductsNavigation { get; set; }
        public virtual Furniture? IdFurnitureProductsNavigation { get; set; }
        public virtual Lock? IdLockProductsNavigation { get; set; }
        public virtual Opening? IdOpeningProductsNavigation { get; set; }
        public virtual Sheath? IdSheathProductsNavigation { get; set; }
        public virtual Typess? IdTypeProductsNavigation { get; set; }
        public virtual WorkSur? IdWorkSurProductsNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
