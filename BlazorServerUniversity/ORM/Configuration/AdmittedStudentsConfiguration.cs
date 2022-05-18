using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerUniversity.Configuration;

public class AdmittedStudentsConfiguration : IEntityTypeConfiguration<ListOfAdmittedStudent>
{
    public void Configure(EntityTypeBuilder<ListOfAdmittedStudent> builder)
    {
        builder.HasNoKey();

        builder.ToView("ListOfAdmittedStudent");

        builder.Property(e => e.DisciplineType).HasColumnName("DisciplineType");

        builder.Property(e => e.Name).HasColumnName("Name");
    }
}