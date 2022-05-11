using System;
using System.Collections.Generic;

namespace BlazorServerUniversity
{
    public partial class ListExamsForEachGroup
    {
        public string? Group { get; set; }
        public string? Discipline { get; set; }
        public string? DisciplineType { get; set; }
        public byte[]? FullName { get; set; }
    }
}
