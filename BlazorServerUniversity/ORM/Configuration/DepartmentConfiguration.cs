using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerUniversity.Configuration;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.HasKey(e => e.IdDepartment);

        builder.Property(e => e.IdDepartment).ValueGeneratedNever();

        builder.HasOne(d => d.Faculty)
            .WithMany(p => p.Departments)
            .HasForeignKey(d => d.FacultyId)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}