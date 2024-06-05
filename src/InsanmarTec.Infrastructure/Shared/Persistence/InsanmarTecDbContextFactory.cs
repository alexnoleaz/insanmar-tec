using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace InsanmarTec.Infrastructure.Shared.Persistence
{
    public class InsanmarTecDbContextFactory : IDesignTimeDbContextFactory<InsanmarTecDbContext>
    {
        public InsanmarTecDbContext CreateDbContext(string[] args)
        {
            var configuration = new InsanmarTecDbContextConfiguration();
            var builder = new DbContextOptionsBuilder<InsanmarTecDbContext>();

            InsanmarTecDbContextConfigurer.Configure(builder, $"{configuration.ConnectionString} Database={configuration.DatabaseName};");
            return new InsanmarTecDbContext(builder.Options);
        }
    }
}
