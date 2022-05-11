using System;
using System.Collections.Generic;

namespace BlazorServerUniversity
{
    public partial class GroupDiscipline
    {
        public long IdGroupDiscipline { get; set; }
        public string? DateStart { get; set; }
        public string? DateEnd { get; set; }
        public long GroupId { get; set; }
        public long DisciplineId { get; set; }

        public virtual Discipline Discipline { get; set; } = null!;
        public virtual Group Group { get; set; } = null!;
    }
}
