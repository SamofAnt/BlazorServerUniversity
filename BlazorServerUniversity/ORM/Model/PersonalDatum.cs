using System;
using System.Collections.Generic;

namespace BlazorServerUniversity
{
    public partial class PersonalDatum
    {
        public PersonalDatum()
        {
            Professors = new HashSet<Professor>();
            Students = new HashSet<Student>();
        }

        public long IdPersonalData { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public long Age { get; set; }
        public string Address { get; set; } = null!;
        public long? StudentId { get; set; }
        public long? ProfessorId { get; set; }

        public virtual Professor? Professor { get; set; }
        public virtual Student? Student { get; set; }
        public virtual ICollection<Professor> Professors { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
