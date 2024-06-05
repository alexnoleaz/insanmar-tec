using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InsanmarTec.WinForms
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration) => _configuration = configuration;

        public void ConfigureServices(IServiceCollection services) { }
    }
}
