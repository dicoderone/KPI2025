using KPIdomain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KPIinfrastructure.Persistence.EntityTypeConfiguration
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Username)
                .HasColumnName("Username")
                .HasMaxLength(64)
                .IsRequired();

            builder.Property(x => x.Password)
                .HasColumnName("Password")
                .HasMaxLength(64)
                .IsRequired();

            builder.HasIndex(x => x.Username)
                .IsUnique();

            builder.HasData(new User
            {
                Id = 1,
                Name = "Otabek Alijonov",
                Role = KPIdomain.Role.UserRole.SuperAdmin,
                Email = "Dicoderone@gmail.com",
                Birthday = new DateTime(2003, 9, 25),
                Username = "SuperAdmin",
                Password = "",
                Passwordhash = ""
            });

        }
    }
}
