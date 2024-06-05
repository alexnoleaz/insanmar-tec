using InsanmarTec.Domain.Shared;
using InsanmarTec.Infrastructure.Shared.Configuration;

namespace InsanmarTec.Infrastructure.Shared.Persistence
{
    public class InsanmarTecDbContextConfiguration
    {
        public readonly string ConnectionString;
        public readonly string DatabaseName;

        public InsanmarTecDbContextConfiguration()
        {
            var configuration = AppConfigurations.Get(ContentDirectoryFinder.CalculateContentRootFolder("InsanmarTec.WinForms"));

            ConnectionString = configuration["Mssql:ConnectionString"]
                ?? throw new Exception("Mssql:ConnectionString is missing in the configuration");

            DatabaseName = configuration["Mssql:DatabaseName"]
                ?? throw new Exception("Mssql:DatabaseName is missing in the configuration");
        }
    }
}
