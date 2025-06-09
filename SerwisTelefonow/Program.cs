using Microsoft.Extensions.DependencyInjection;
using SerwisTelefonow.Data;
using SerwisTelefonow;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using SerwisTelefonow.Models;

internal static class Program
{
    public static IServiceProvider ServiceProvider { get; private set; }
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var host = Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration(config =>
            {
                config.SetBasePath(AppContext.BaseDirectory);
                config.AddJsonFile("appsettings.json", optional: false);
            })
            .ConfigureServices((context, services) =>
            {
                // Pobieranie connection string z konfiguracji
                string connectionString = context.Configuration.GetConnectionString("DefaultConnection");

                services.AddDbContext<AppDbContext>(options =>
                    options.UseNpgsql(connectionString));

                services.AddTransient<StronaGlowna>();
                services.AddTransient<AddNewServRecord>();
                services.AddTransient<SearchServRecords>();
            })
            .Build();

        ServiceProvider = host.Services;
        using (var scope = host.Services.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            context.Database.Migrate();
            context.SeedDatabaseFromSqlScriptIfEmpty(); 
        }


        Application.Run(ServiceProvider.GetRequiredService<StronaGlowna>());
        //Application.Run(new StronaGlowna());
    }

}