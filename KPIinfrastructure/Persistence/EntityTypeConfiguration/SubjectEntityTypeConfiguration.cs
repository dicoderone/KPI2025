using KPIdomain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KPIinfrastructure.Persistence.EntityTypeConfiguration
{
    public class SubjectEntityTypeConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable(nameof(Subject));

            builder.HasKey(x => x.Id);

            builder.Property(s => s.Name)
                      .IsRequired()
                      .HasMaxLength(100);

            builder.Property(s => s.IsComplex)
                      .HasDefaultValue(false);
        }
    }
}
