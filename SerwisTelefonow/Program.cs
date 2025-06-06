using Microsoft.Extensions.DependencyInjection;
using SerwisTelefonow.Data;
using SerwisTelefonow;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

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
        Application.Run(new StronaGlowna());
    }
}