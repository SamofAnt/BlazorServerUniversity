using System;
using System.Collections.Generic;

namespace BlazorServerUniversity
{
    public partial class DisciplineType
    {
        public DisciplineType()
        {
            Disciplines = new HashSet<Discipline>();
        }

        public long IdDisciplineType { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Discipline> Disciplines { get; set; }
    }
}
