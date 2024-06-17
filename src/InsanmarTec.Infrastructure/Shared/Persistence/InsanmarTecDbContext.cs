using InsanmarTec.Domain.Brands;
using Microsoft.EntityFrameworkCore;

namespace InsanmarTec.Infrastructure.Shared.Persistence
{
    public class InsanmarTecDbContext : DbContext
    {
        public InsanmarTecDbContext(DbContextOptions<InsanmarTecDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(InfrastructureModule).Assembly);
            modelBuilder.ApplyFilterByIsDeleted();
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            configurationBuilder.Properties<string>().HaveColumnType("varchar");
        }

        // Define a DbSet for each entity of the application
        public DbSet<Brand> Brands => Set<Brand>();
    }
}
