using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.Contracts.Order
{
    public record AddOrderRequest(
        int idClient,
        int idProduct
    );
}
