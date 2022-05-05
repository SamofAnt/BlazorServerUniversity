using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerUniversity.Configuration;

public class DisciplineTypeConfiguration : IEntityTypeConfiguration<DisciplineType>
{
    public void Configure(EntityTypeBuilder<DisciplineType> builder)
    {
        builder.HasKey(e => e.IdDisciplineType);

        builder.Property(e => e.IdDisciplineType).ValueGeneratedNever();
        
    }
}