using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.Contracts.Craftsmen
{
    public record CraftsmenResponse(
        int Id,
        string surname,
        string name,
        string patronymic,
        string rank,
        string rating,
        string exp,
        string phone);
}
