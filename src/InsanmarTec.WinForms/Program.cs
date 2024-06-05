using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

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
            Application.Run(CreateHostBuilder().Build().Services.GetRequiredService<Form1>());
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(configuration =>
                    configuration
                        .SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location)!)
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true))
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<Form1>();
                    new Startup(context.Configuration).ConfigureServices(services);
                });

    }
}