using System;
using System.Collections.Generic;

namespace BlazorServerUniversity
{
    public partial class Professor
    {
        public Professor()
        {
            Disciplines = new HashSet<Discipline>();
            PersonalData = new HashSet<PersonalDatum>();
        }

        public long IdProfessor { get; set; }
        public long DepartmentId { get; set; }
        public long PersonalDataId { get; set; }

        public virtual Department Department { get; set; } = null!;
        public virtual PersonalDatum PersonalDataNavigation { get; set; } = null!;
        public virtual ICollection<Discipline> Disciplines { get; set; }
        public virtual ICollection<PersonalDatum> PersonalData { get; set; }
    }
}
