using System;
using System.Collections.Generic;

namespace BlazorServerUniversity
{
    public partial class Discipline
    {
        public Discipline()
        {
            GroupDisciplines = new HashSet<GroupDiscipline>();
            StudentDisciplines = new HashSet<StudentDiscipline>();
        }

        public long IdDiscipline { get; set; }
        public string Name { get; set; } = null!;
        public long LectureHours { get; set; }
        public string PracticeHours { get; set; } = null!;
        public long DisciplineTypeId { get; set; }
        public long ProfessorId { get; set; }
        public long DepartmentId { get; set; }

        public virtual Department Department { get; set; } = null!;
        public virtual DisciplineType DisciplineType { get; set; } = null!;
        public virtual Professor Professor { get; set; } = null!;
        public virtual ICollection<GroupDiscipline> GroupDisciplines { get; set; }
        public virtual ICollection<StudentDiscipline> StudentDisciplines { get; set; }
    }
}
