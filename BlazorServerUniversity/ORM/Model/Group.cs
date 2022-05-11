using System;
using System.Collections.Generic;

namespace BlazorServerUniversity
{
    public partial class Group
    {
        public Group()
        {
            GroupDisciplines = new HashSet<GroupDiscipline>();
            Students = new HashSet<Student>();
        }

        public long IdGroup { get; set; }
        public string Name { get; set; } = null!;
        public long SpecialityId { get; set; }

        public virtual Speciality Speciality { get; set; } = null!;
        public virtual ICollection<GroupDiscipline> GroupDisciplines { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
