using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerUniversity.Configuration;

public class GroupConfiguration: IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasKey(e => e.IdGroup);

        builder.Property(e => e.IdGroup).ValueGeneratedNever();

        builder.HasOne(d => d.Speciality)
            .WithMany(p => p.Groups)
            .HasForeignKey(d => d.SpecialityId)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}