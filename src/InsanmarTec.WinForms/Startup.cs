using InsanmarTec.Application;
using InsanmarTec.Domain;
using InsanmarTec.Infrastructure;
using InsanmarTec.Infrastructure.Shared.Dependency;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InsanmarTec.WinForms
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration) => _configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutomaticRegistered(typeof(InfrastructureModule).Assembly);
            services.AddAutomaticRegistered(typeof(DomainModule).Assembly);
            services.AddAutomaticRegistered(typeof(ApplicationModule).Assembly);
            services.AddAutomaticRegistered(typeof(Startup).Assembly);
        }
    }
}
