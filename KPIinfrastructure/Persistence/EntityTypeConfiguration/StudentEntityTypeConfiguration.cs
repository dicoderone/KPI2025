using KPIdomain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KPIinfrastructure.Persistence.EntityTypeConfiguration
{
    public class StudentEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");

            // Primary Key
            builder.HasKey(s => s.Id);

            builder.Property(s => s.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(s => s.LastName)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(s => s.Teacher)
                .WithMany(t => t.Students)          // Har bir o‘qituvchining bir nechta o‘quvchisi bo‘lishi mumkin
                .HasForeignKey(s => s.TeacherId)
                .OnDelete(DeleteBehavior.Cascade); // O‘qituvchi o‘chirilsa, bog‘langan studentlar ham o‘chadi

            builder.HasMany(s => s.Grades)
                .WithOne(g => g.Student)
                .HasForeignKey(g => g.StudentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}



