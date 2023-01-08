using System;
using System.Collections.Generic;

namespace worksop.Models
{
    public partial class Furniture
    {
        public Furniture()
        {
            Products = new HashSet<Product>();
        }

        public int IdFurnitures { get; set; }
        public int? RatingFurnitures { get; set; }
        public string? MaterialFurnitures { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
