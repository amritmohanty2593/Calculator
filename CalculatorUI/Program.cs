using CalculatorUI.Core.Classes;
using CalculatorUI.Core.Core;
using CalculatorUI.Core.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System.Configuration;
using System.Reflection;

namespace CalculatorUI
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
            var config = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location))
                .AddJsonFile("appsettings.json")
                .Build();

            Log.Logger = new LoggerConfiguration()
                 .MinimumLevel.Information()
                 .ReadFrom.Configuration(config)
                 .Enrich.FromLogContext()
                 .WriteTo.Console()
                 .WriteTo.File(Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location)+"\\"+"log.txt", rollingInterval: RollingInterval.Day).CreateLogger();
            Log.Logger.Information("Application Started");
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<Calculator>());

        }
        
        public static IServiceProvider? ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().UseSerilog()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<IStandardArithmaticOps, StandardArithmaticOps>();
                    services.AddSingleton<ICommonArithmaticOps, CommonArithmaticOps>();
                    services.AddSingleton<ICoreLogic, Corelogic>(x => new Corelogic(iCommonArtimaticOps: new CommonArithmaticOps()));
                    services.AddLogging(loggingBuilder =>loggingBuilder.AddSerilog(dispose: true).AddConsole().AddDebug());
                    services.AddTransient<Calculator>();
                });
        }
    }
}