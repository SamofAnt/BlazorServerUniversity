using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerUniversity.Configuration;

public class ExamsConfiguration : IEntityTypeConfiguration<ListExamsForEachGroup>
{
    public void Configure(EntityTypeBuilder<ListExamsForEachGroup> builder)
    {
        builder.HasNoKey();

        builder.ToView("ListExamsForEachGroup");

        builder.Property(e => e.FullName).HasColumnName("Full Name");
    }
}