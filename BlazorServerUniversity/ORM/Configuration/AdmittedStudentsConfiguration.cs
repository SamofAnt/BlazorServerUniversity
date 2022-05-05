using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerUniversity.Configuration;

public class AdmittedStudentsConfiguration : IEntityTypeConfiguration<ListOfAdmittedStudent>
{
    public void Configure(EntityTypeBuilder<ListOfAdmittedStudent> builder)
    {
        builder.HasNoKey();

        builder.ToView("ListOfAdmittedStudents");

        builder.Property(e => e.DisciplineType).HasColumnName("Discipline Type");

        builder.Property(e => e.FullName).HasColumnName("Full Name");
    }
}