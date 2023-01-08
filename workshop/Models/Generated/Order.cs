using System;
using System.Collections.Generic;

namespace worksop.Models
{
    public partial class Order
    {
        public int IdOrders { get; set; }
        public int? IdclntOrders { get; set; }
        public int? IdProductOrders { get; set; }
        public DateTime? StartDateOrders { get; set; }

        public virtual Product? IdProductOrdersNavigation { get; set; }
        public virtual Client? IdclntOrdersNavigation { get; set; }
    }
}
