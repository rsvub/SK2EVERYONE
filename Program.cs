using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;
using SK2EVERYONE.BLL;
using Microsoft.Extensions.Logging;
using System.Text;
using SK2EVERYONE.DAL.HIHs;
using SK2EVERYONE.DAL.Patients;
using SK2EVERYONE.DAL.LoyaltyCards;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddScoped<ISourceConnectionProvider, SourceConnectionProvider>();
        services.AddScoped<IFirebirdConnectionProvider, FirebirdConnectionProvider>();
        services.AddTransient<IFirebirdCreateDb, FirebirdCreateDb>();
        services.AddTransient<IFirebirdCreateTable, HIHFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, PatientFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, LoyaltyCardFirebirdCreateTabel>(); // - musim doresit fk na jine tabulky (ano ci ne?)
        services.AddTransient<ISrcDb<HIH>, HIHSrcDb>();
        services.AddTransient<ISrcDb<Patient>, PatientSrcDb>();
        services.AddTransient<IFirebirdDb<HIH>, HIHFirebirdDb>();
        services.AddTransient<IFirebirdDb<Patient>, PatientFirebirdDb>();
        services.AddTransient<IImporter<HIH>, HIHImporter>();
        services.AddTransient<IImporter<Patient>, PatientImporter>();
    })
    .Build();

using var scope = host.Services.CreateScope();
IServiceProvider provider = scope.ServiceProvider;
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
var createFbDatabase = provider.GetRequiredService<IFirebirdCreateDb>();
createFbDatabase.CreateFbDatabase();
ILoggerFactory loggerFactory = provider.GetRequiredService<ILoggerFactory>();
var loggerPath = Path.Combine(Directory.GetCurrentDirectory(), $"{args[0]}");
if (!Directory.Exists(loggerPath)) Directory.CreateDirectory(loggerPath);
using var logger = loggerFactory.AddFile(loggerPath);

foreach (var creator in provider.GetServices<IFirebirdCreateTable>())
{ 
    creator.Create();
}


switch (args[1].ToLowerInvariant())
{ 
    case "import":
        var hIHImporter = provider.GetRequiredService<IImporter<HIH>>();
            hIHImporter.Import();
        var patientImporter = provider.GetRequiredService<IImporter<Patient>>();
            patientImporter.Import();
    break;
    case "createdb":
        Console.WriteLine("Under construction!");
    break;
    default:
        Console.WriteLine($"Unknown option {args[1]}");
    break;
}
Console.ReadKey();


