using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.Infrastructure.Shared.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace InsanmarTec.Infrastructure.Shared.Dependency
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddAutomaticRegistered(this IServiceCollection services, Assembly assembly)
        {
            var types = assembly.GetTypes()
                                        .Where(t => t.IsClass && !t.IsAbstract && !t.IsGenericTypeDefinition);

            // Register transient types
            foreach (var type in types.Where(t => t.GetInterfaces().Contains(typeof(ITransientDependency))))
            {
                var serviceInterfaces = type.GetInterfaces()
                    .Where(i => i != typeof(ITransientDependency))
                    .ToList();

                foreach (var serviceInterface in serviceInterfaces)
                {
                    services.AddTransient(serviceInterface, type);
                }
                services.AddTransient(type);
            }

            // Register singleton types 
            foreach (var type in types.Where(t => t.GetInterfaces().Contains(typeof(ISingletonDependency))))
            {
                var serviceInterfaces = type.GetInterfaces()
                    .Where(i => i != typeof(ISingletonDependency))
                    .ToList();

                foreach (var serviceInterface in serviceInterfaces)
                {
                    services.AddSingleton(serviceInterface, type);
                }
                services.AddSingleton(type);
            }

            return services;
        }

        public static IServiceCollection Install(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<InsanmarTecDbContext>(options =>
                options.UseSqlServer($"{configuration["Mssql:ConnectionString"]} Database={configuration["Mssql:DatabaseName"]};"));

            return services;
        }
    }
}
