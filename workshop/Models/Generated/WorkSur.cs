using System;
using System.Collections.Generic;

namespace worksop.Models
{
    public partial class WorkSur
    {
        public WorkSur()
        {
            Products = new HashSet<Product>();
        }

        public int IdWorkSurs { get; set; }
        public int? WeightWorkSurs { get; set; }
        public int? LengthWorkSurs { get; set; }
        public int? AngleWorkSurs { get; set; }
        public int? IdShapeWorkSurs { get; set; }
        public int? IdSteelWorkSurs { get; set; }

        public virtual Shape? IdShapeWorkSursNavigation { get; set; }
        public virtual Steel? IdSteelWorkSursNavigation { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
