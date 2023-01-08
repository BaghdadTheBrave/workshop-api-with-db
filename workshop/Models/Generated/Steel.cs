using System;
using System.Collections.Generic;

namespace worksop.Models
{
    public partial class Steel
    {
        public Steel()
        {
            WorkSurs = new HashSet<WorkSur>();
        }

        public int IdSteel { get; set; }
        public string? NameSteel { get; set; }

        public virtual ICollection<WorkSur> WorkSurs { get; set; }
    }
}
