using Microsoft.EntityFrameworkCore;

namespace InsanmarTec.Infrastructure.Shared.Persistence
{
    public class InsanmarTecDbContext : DbContext
    {
        public InsanmarTecDbContext(DbContextOptions<InsanmarTecDbContext> options) : base(options) { }
    }
}
