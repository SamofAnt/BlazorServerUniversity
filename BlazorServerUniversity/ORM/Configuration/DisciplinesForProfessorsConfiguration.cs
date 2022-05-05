using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerUniversity.Configuration;

public class DisciplinesForProfessorConfiguration : IEntityTypeConfiguration<ListOfDisciplinesForEachProfessor>
{
    public void Configure(EntityTypeBuilder<ListOfDisciplinesForEachProfessor> builder)
    {
        builder.HasNoKey();

        builder.ToView("ListOfDisciplinesForEachProfessors");

        builder.Property(e => e.DisciplineType).HasColumnName("Discipline Type");

    }
}