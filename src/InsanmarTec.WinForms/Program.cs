using System.Reflection;
using InsanmarTec.Application;
using InsanmarTec.Domain.Shared.Datasources;
using InsanmarTec.Infrastructure.Shared.Persistence;
using InsanmarTec.Infrastructure.Shared.Persistence.Datasources;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace InsanmarTec.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(
                CreateHostBuilder().Build().Services.GetRequiredService<Form1>()
            );
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(configuration =>
                    configuration
                        .SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location)!)
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                )
                .ConfigureServices(
                    (context, services) =>
                    {
                        services.AddDbContext<InsanmarTecDbContext>(options =>
                            options.UseSqlServer(
                                $"{context.Configuration["Mssql:ConnectionString"]} Database={context.Configuration["Mssql:DatabaseName"]};"
                            )
                        );
                        services.AddAutoMapper(typeof(ApplicationModule).Assembly);
                        services.AddTransient(typeof(IDatasource<,>), typeof(Datasource<,>));
                        services.AddTransient(typeof(IDatasource<>), typeof(Datasource<>));

                        new Startup(context.Configuration).ConfigureServices(services);
                    }
                );
    }
}
