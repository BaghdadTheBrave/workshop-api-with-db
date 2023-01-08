using System;
using System.Collections.Generic;

namespace worksop.Models
{
    public partial class Client
    {
        public Client()
        {
            Orders = new HashSet<Order>();
        }

        public int IdClients { get; set; }
        public string? SurnameClients { get; set; }
        public string? NameClients { get; set; }
        public string? PatronymicClients { get; set; }
        public string? SettlmentClients { get; set; }
        public string? FlatClients { get; set; }
        public string? StreetClients { get; set; }
        public string? HouseClients { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
