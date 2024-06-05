using Microsoft.Extensions.Configuration;
using System.Collections.Concurrent;

namespace InsanmarTec.Infrastructure.Shared.Configuration
{
    public class AppConfigurations
    {
        private static readonly ConcurrentDictionary<string, IConfiguration> _configurationCache;

        static AppConfigurations() => _configurationCache = new ConcurrentDictionary<string, IConfiguration>();

        private static IConfiguration BuildConfiguration(string path) =>
            new ConfigurationBuilder()
                .SetBasePath(path)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

        public static IConfiguration Get(string path) =>
            _configurationCache.GetOrAdd(path, _ => BuildConfiguration(path));
    }
}
