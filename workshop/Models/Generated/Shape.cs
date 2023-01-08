using System;
using System.Collections.Generic;

namespace worksop.Models
{
    public partial class Shape
    {
        public Shape()
        {
            WorkSurs = new HashSet<WorkSur>();
        }

        public int IdShapes { get; set; }
        public string? NameShapes { get; set; }

        public virtual ICollection<WorkSur> WorkSurs { get; set; }
    }
}
