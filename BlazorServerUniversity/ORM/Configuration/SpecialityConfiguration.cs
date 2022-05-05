using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerUniversity.Configuration;

public class SpecialityConfiguration : IEntityTypeConfiguration<Speciality>
{
    public void Configure(EntityTypeBuilder<Speciality> builder)
    {
        builder.HasKey(e => e.IdSpeciality);

        builder.ToTable("Speciality");

        builder.Property(e => e.IdSpeciality).ValueGeneratedNever();

        builder.HasOne(d => d.Department)
            .WithMany(p => p.Specialities)
            .HasForeignKey(d => d.DepartmentId)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}