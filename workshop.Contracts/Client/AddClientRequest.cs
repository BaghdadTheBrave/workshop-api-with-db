using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.Contracts.Client
{
    public record AddClientRequest(
        string surname,
        string name,
        string patronymic,
        string settlment,
        string flat,
        string street,
        string house,
        DateOnly date_of_birth,
        string phone
        );
}
