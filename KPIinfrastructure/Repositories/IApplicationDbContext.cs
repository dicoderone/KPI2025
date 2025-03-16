using KPIdomain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace KPIapplication.Repositories
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Document> Documents { get; set; }
        DbSet<UserSession> Sessions { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
