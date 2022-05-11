using System;
using System.Collections.Generic;

namespace BlazorServerUniversity
{
    public partial class Student
    {
        public Student()
        {
            PersonalData = new HashSet<PersonalDatum>();
            StudentDisciplines = new HashSet<StudentDiscipline>();
        }

        public long IdStudent { get; set; }
        public long Course { get; set; }
        public long IsStudy { get; set; }
        public long GroupId { get; set; }
        public long PersonalDataId { get; set; }

        public virtual Group Group { get; set; } = null!;
        public virtual PersonalDatum PersonalDataNavigation { get; set; } = null!;
        public virtual ICollection<PersonalDatum> PersonalData { get; set; }
        public virtual ICollection<StudentDiscipline> StudentDisciplines { get; set; }
    }
}
