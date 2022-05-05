using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerUniversity.Configuration;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(e => e.IdStudent);

        builder.Property(e => e.IdStudent).ValueGeneratedNever();

        builder.HasOne(d => d.Group)
            .WithMany(p => p.Students)
            .HasForeignKey(d => d.GroupId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(d => d.PersonalDataNavigation)
            .WithMany(p => p.Students)
            .HasForeignKey(d => d.PersonalDataId);
    }
}