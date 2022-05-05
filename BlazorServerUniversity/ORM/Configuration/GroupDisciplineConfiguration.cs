using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerUniversity.Configuration;

public class GroupDisciplineConfiguration : IEntityTypeConfiguration<GroupDiscipline>
{
    public void Configure(EntityTypeBuilder<GroupDiscipline> builder)
    {
        builder.HasKey(e => e.IdGroupDiscipline);

        builder.ToTable("GroupDiscipline");

        builder.Property(e => e.IdGroupDiscipline).ValueGeneratedNever();

        builder.Property(e => e.DateEnd).HasColumnName("dateEnd");

        builder.Property(e => e.DateStart).HasColumnName("dateStart");

        builder.HasOne(d => d.Discipline)
            .WithMany(p => p.GroupDisciplines)
            .HasForeignKey(d => d.DisciplineId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(d => d.Group)
            .WithMany(p => p.GroupDisciplines)
            .HasForeignKey(d => d.GroupId)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}