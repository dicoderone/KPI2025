using KPIdomain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KPIinfrastructure.Persistence.EntityTypeConfiguration
{
    public class GradesEntityTypeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.ToTable(nameof(Grade));

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Student)
                .WithMany(s => s.Grades)
                .HasForeignKey(g => g.StudentId)
                .OnDelete(DeleteBehavior.Cascade);              // Agar Student o'chirilsa, uning Grades ham o'chadi

            builder.Property(g => g.Value)
                      .IsRequired()
                      .HasAnnotation("Range", new[] { 2, 5 });

            builder.HasOne(g => g.Subject)
                      .WithMany()
                      .HasForeignKey(g => g.SubjectId)
                      .OnDelete(DeleteBehavior.Restrict);       // Agar Subject o'chirilsa, Grades o'chmaydi
        }
    }
}
