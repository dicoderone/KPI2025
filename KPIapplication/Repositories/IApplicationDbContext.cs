using KPIdomain.Models;
using Microsoft.EntityFrameworkCore;

namespace KPIapplication.Repositories
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Teacher> Teachers { get; set; }
        DbSet<Grade> Grades { get; set; }
        DbSet<Student> Students { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
