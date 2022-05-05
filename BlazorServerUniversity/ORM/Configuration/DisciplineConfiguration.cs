using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerUniversity.Configuration;

public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
{
    public void Configure(EntityTypeBuilder<Discipline> builder)
    {
        builder.HasKey(e => e.IdDiscipline);

        builder.Property(e => e.IdDiscipline).ValueGeneratedNever();

         builder.HasOne(d => d.Department)
            .WithMany(p => p.Disciplines)
            .HasForeignKey(d => d.DepartmentId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(d => d.DisciplineType)
            .WithMany(p => p.Disciplines)
            .HasForeignKey(d => d.DisciplineTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(d => d.Professor)
            .WithMany(p => p.Disciplines)
            .HasForeignKey(d => d.ProfessorId)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}