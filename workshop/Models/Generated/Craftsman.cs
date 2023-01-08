using System;
using System.Collections.Generic;

namespace worksop.Models
{
    public partial class Craftsman
    {
        public Craftsman()
        {
            Products = new HashSet<Product>();
        }

        public int IdCraftsmen { get; set; }
        public string? SurnameCraftsmen { get; set; }
        public string? NameCraftsmen { get; set; }
        public string? PatronymicCraftsmen { get; set; }
        public string? RankCraftsmen { get; set; }
        public string? RatingCraftsmen { get; set; }
        public string? ExpCraftsmen { get; set; }
        public string? Phone { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
