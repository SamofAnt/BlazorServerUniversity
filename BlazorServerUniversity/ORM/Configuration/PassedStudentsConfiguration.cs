using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerUniversity.Configuration;

public class PassedStudentsConfiguration: IEntityTypeConfiguration<StudentsWhoPayPass>
{
    public void Configure(EntityTypeBuilder<StudentsWhoPayPass> builder)
    {
        builder.HasNoKey();

        builder.ToView("StudentsWhoPayPass");

        builder.Property(e => e.Name).HasColumnName("Name");
    }
}