using System;
using System.Collections.Generic;

namespace BlazorServerUniversity
{
    public partial class StudentDiscipline
    {
        public long IdStudentDiscipline { get; set; }
        public long StudentId { get; set; }
        public long DisciplineId { get; set; }
        public long IsPay { get; set; }
        public long Grade { get; set; }

        public virtual Discipline Discipline { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
