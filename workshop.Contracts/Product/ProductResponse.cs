using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.Contracts.Product
{
    public record ProductResponse
    (
        int id,
        string name,
        int weight,
        int length,
        int lengthWorkSur,
        int angle,
        string shape,
        string steel,
        string furniture,
        string sheath,
        int craftsmanId,
        string craftsman,
        string type,
        string lockName

    );
}
