using Serilog;
using Servicio.Sensor;
using Servicio.Metrics;
using Servicio;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;



// Create a host builder
var builder = Host.CreateApplicationBuilder(args);

// Configure logging
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .WriteTo.Console()
    .WriteTo.File(
        path: "logs/termicologs-.csv",
        outputTemplate: "{Timestamp:0};{Message.1}{NewLine}",
        rollingInterval: RollingInterval.Day
    ).CreateLogger();

// Configure services
builder.Logging.ClearProviders();
// Add Serilog as the logging provider
builder.Logging.AddSerilog();



// Inyectar nuevas dependencias
builder.Services.AddSingleton<HardwareReader>();
builder.Services.AddSingleton<CsWriter>();
builder.Services.AddHostedService<MetricExporter>();
builder.Services.AddHostedService<Worker>();

// Configure la aplicación para ejecutarse como un servicio
if (OperatingSystem.IsWindows() && !args.Contains("--console"))
{
    // Configurar el servicio para Windows
    builder.Services.AddWindowsService(Options =>
        Options.ServiceName = "Servicio Termico");
}

await builder.Build().RunAsync();