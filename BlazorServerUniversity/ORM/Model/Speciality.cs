using System;
using System.Collections.Generic;

namespace BlazorServerUniversity
{
    public partial class Speciality
    {
        public Speciality()
        {
            Groups = new HashSet<Group>();
        }

        public long IdSpeciality { get; set; }
        public string Name { get; set; } = null!;
        public long DepartmentId { get; set; }

        public virtual Department Department { get; set; } = null!;
        public virtual ICollection<Group> Groups { get; set; }
    }
}
