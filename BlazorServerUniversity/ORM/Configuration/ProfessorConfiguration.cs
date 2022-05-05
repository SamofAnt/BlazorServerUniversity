using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerUniversity.Configuration;

public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
{
    public void Configure(EntityTypeBuilder<Professor> builder)
    {
        builder.HasKey(e => e.IdProfessor);

        builder.Property(e => e.IdProfessor).ValueGeneratedNever();

        builder.HasOne(d => d.Department)
            .WithMany(p => p.Professors)
            .HasForeignKey(d => d.DepartmentId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(d => d.PersonalDataNavigation)
            .WithMany(p => p.Professors)
            .HasForeignKey(d => d.PersonalDataId)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}