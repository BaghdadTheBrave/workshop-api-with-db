using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.Contracts.Client
{

    public record ClientResponse(
        int Id,
        string surname,
        string name,
        string patronymic,
        string settlment,
        string flat,
        string street,
        string house,
        int year,
        int month,
        int day,
        string phone
        );
    
}
