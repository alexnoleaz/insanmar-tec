using Microsoft.EntityFrameworkCore;

namespace InsanmarTec.Infrastructure.Shared.Persistence
{
    public class InsanmarTecDbContext : DbContext
    {
        public InsanmarTecDbContext(DbContextOptions<InsanmarTecDbContext> options) : base(options) { }

        // Define a DbSet for each entity of the application
    }
}
