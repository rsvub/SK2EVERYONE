using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;
using SK2EVERYONE.BLL;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddScoped<ISrcDb<HIH>, HIHSrcDb>();
        services.AddScoped<ISrcDb<Patient>, PatientSrcDb>();
        services.AddScoped<IHIHFirebirdDb, HIHFirebirdDb>();
        services.AddTransient<IHIHImporter, HIHImporter>();
    })
    .Build();

using var scope = host.Services.CreateScope();
IServiceProvider provider = scope.ServiceProvider;

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


