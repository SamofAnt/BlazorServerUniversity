using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerUniversity.Configuration;

public class PersonalDataConfiguration: IEntityTypeConfiguration<PersonalDatum>
{
    public void Configure(EntityTypeBuilder<PersonalDatum> builder)
    {
        builder.HasKey(e => e.IdPersonalData);

        builder.Property(e => e.IdPersonalData).ValueGeneratedNever();

        builder.HasOne(d => d.Professor)
            .WithMany(p => p.PersonalData)
            .HasForeignKey(d => d.ProfessorId);

        builder.HasOne(d => d.Student)
            .WithMany(p => p.PersonalData)
            .HasForeignKey(d => d.StudentId);
    }
}