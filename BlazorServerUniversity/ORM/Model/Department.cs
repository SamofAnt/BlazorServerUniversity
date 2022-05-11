using System;
using System.Collections.Generic;

namespace BlazorServerUniversity
{
    public partial class Department
    {
        public Department()
        {
            Disciplines = new HashSet<Discipline>();
            Professors = new HashSet<Professor>();
            Specialities = new HashSet<Speciality>();
        }

        public long IdDepartment { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public long FacultyId { get; set; }

        public virtual Faculty Faculty { get; set; } = null!;
        public virtual ICollection<Discipline> Disciplines { get; set; }
        public virtual ICollection<Professor> Professors { get; set; }
        public virtual ICollection<Speciality> Specialities { get; set; }
    }
}
