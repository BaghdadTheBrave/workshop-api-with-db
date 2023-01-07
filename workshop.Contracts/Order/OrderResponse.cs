using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.Contracts.Order
{
    public record OrderResponse
    (
        int id,
        int idClient,
        string clientName,
        int idProduct,
        string productName,
        DateOnly startDate
    );
}
