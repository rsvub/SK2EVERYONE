using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SK2EVERYONE.DAL;

var host = Host.CreateDefaultBuilder(args).Build();

IConfiguration config = host.Services.GetRequiredService<IConfiguration>();

if (args[1] == "import")
{
    using HIHFirebirdDb fbDb = new HIHFirebirdDb(config);
    var hihs = new HIHSrcDb(config).GetAllHIH();

    foreach (var hih in hihs)
    {
        Console.WriteLine("RegionIdZP: " + hih.Id + " Name: " + hih.Name + " Region: " + hih.Region + " IdZP: " + hih.IdWithoutRegion);
        fbDb.InsertHIH(hih);
    };
    Console.WriteLine("Import HIH to Firebird OK!");
    Console.ReadKey();
}
if (args[1] == "createdb")
{
    Console.WriteLine("Under construction!");
    Console.ReadKey();
}

