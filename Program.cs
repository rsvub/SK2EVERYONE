using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;
using SK2EVERYONE.BLL;
using Microsoft.Extensions.Logging;


FirebirdCreateDb.CreateFBDatabase();

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddScoped<ISourceConnectionProvider, SourceConnectionProvider>();
        services.AddScoped<IFirebirdConnectionProvider, FirebirdConnectionProvider>();
        services.AddTransient<IFirebirdCreateTable<HIH>, HIHFirebirdCreateTable>();
        services.AddTransient<ISrcDb<HIH>, HIHSrcDb>();
        services.AddTransient<ISrcDb<Patient>, PatientSrcDb>();
        services.AddTransient<IFirebirdDb<HIH>, HIHFirebirdDb>();
        services.AddTransient<IHIHImporter, HIHImporter>();
    })
    .Build();

using var scope = host.Services.CreateScope();
IServiceProvider provider = scope.ServiceProvider;
ILoggerFactory loggerFactory = provider.GetRequiredService<ILoggerFactory>();
var loggerPath = Path.Combine(Directory.GetCurrentDirectory(), $"{args[0]}");
if (!Directory.Exists(loggerPath)) Directory.CreateDirectory(loggerPath);
using var logger = loggerFactory.AddFile(Path.Combine(Directory.GetCurrentDirectory(), $"{args[0]}"));


var firebirdCreateTableHIH = provider.GetRequiredService<IFirebirdCreateTable<HIH>>();
firebirdCreateTableHIH.Create<HIH>();


switch (args[1].ToLowerInvariant())
{ 
    case "import":
    var importer = provider.GetRequiredService<IHIHImporter>();
    importer.Import();
    break;
case "createdb":
    Console.WriteLine("Under construction!");
    break;
default:
    Console.WriteLine($"Unknown option {args[1]}");
    break;
}
Console.ReadKey();


