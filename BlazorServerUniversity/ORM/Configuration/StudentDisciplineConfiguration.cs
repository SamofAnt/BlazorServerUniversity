using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerUniversity.Configuration;

public class StudentDisciplineConfiguration : IEntityTypeConfiguration<StudentDiscipline>
{
    public void Configure(EntityTypeBuilder<StudentDiscipline> builder)
    {
        builder.HasKey(e => e.IdStudentDiscipline);

        builder.ToTable("StudentDiscipline");

        builder.Property(e => e.IdStudentDiscipline).ValueGeneratedNever();

        builder.Property(e => e.IsPay).HasColumnName("isPay");

        builder.HasOne(d => d.Discipline)
            .WithMany(p => p.StudentDisciplines)
            .HasForeignKey(d => d.DisciplineId);

        builder.HasOne(d => d.Student)
            .WithMany(p => p.StudentDisciplines)
            .HasForeignKey(d => d.StudentId);
    }
}