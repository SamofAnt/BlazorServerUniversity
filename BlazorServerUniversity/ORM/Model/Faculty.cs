using System;
using System.Collections.Generic;

namespace BlazorServerUniversity
{
    public partial class Faculty
    {
        public Faculty()
        {
            Departments = new HashSet<Department>();
        }

        public long IdFaculty { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Department> Departments { get; set; }
    }
}
