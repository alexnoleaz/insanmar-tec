using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace InsanmarTec.Infrastructure.Shared.Persistence
{
    public class InsanmarTecDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<InsanmarTecDbContext> builder, string connectionString) =>
            builder.UseSqlServer(connectionString);

        public static void Configure(DbContextOptionsBuilder<InsanmarTecDbContext> builder, DbConnection connection) =>
            builder.UseSqlServer(connection);
    }
}
