﻿using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;
using SK2EVERYONE.BLL;
using Microsoft.Extensions.Logging;
using System.Text;
using SK2EVERYONE.DAL.HIHs;
using SK2EVERYONE.DAL.Patients;
using SK2EVERYONE.DAL.LoyaltyCards;
using SK2EVERYONE.DAL.Partners;
using SK2EVERYONE.DAL.Products;
using SK2EVERYONE.DAL.Stock;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddScoped<ISourceConnectionProvider, SourceConnectionProvider>();
        services.AddScoped<IFirebirdConnectionProvider, FirebirdConnectionProvider>();
        services.AddTransient<IFirebirdCreateDb, FirebirdCreateDb>();
        services.AddTransient<IFirebirdCreateTable, HIHFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, PatientFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, LoyaltyCardFirebirdCreateTable>(); // - musim doresit fk na jine tabulky (ano ci ne?)
        services.AddTransient<IFirebirdCreateTable, CommunicationSettingsFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, PartnerFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, ProductFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, PharmacyStockCreateTable>();
        services.AddTransient<IFirebirdCreateTable, DegressiveMarginCreateTable>();
        services.AddTransient<ISrcDb<HIH>, HIHSrcDb>();
        services.AddTransient<ISrcDb<Patient>, PatientSrcDb>();
        services.AddTransient<ISrcDb<LoyaltyCard>, LoyaltyCardSrcDb>();
        services.AddTransient<ISrcDb<CommunicationSettings>, CommunicationSettingsSrcDB>();
        services.AddTransient<ISrcDb<Partner>, PartnerSrcDb>();
        services.AddTransient<ISrcDb<Product>, ProductSrcDb>();
        services.AddTransient<ISrcDb<PharmacyStock>, PharmacyStockSrcDb>();
        services.AddTransient<ISrcDb<DegressiveMargin>, DegressiveMarginSrcDb>();
        services.AddTransient<IFirebirdDb<HIH>, HIHFirebirdDb>();
        services.AddTransient<IFirebirdDb<Patient>, PatientFirebirdDb>();
        services.AddTransient<IFirebirdDb<LoyaltyCard>, LoyaltyCardFirebirdDb>();
        services.AddTransient<IFirebirdDb<CommunicationSettings>, CommunicationSettingsFirebirdDb>();
        services.AddTransient<IFirebirdDb<Partner>, PartnerFirebirdDb>();
        services.AddTransient<IFirebirdDb<Product>, ProductFirebirdDb>();
        services.AddTransient<IFirebirdDb<PharmacyStock>, PharmacyStockFirebirdDb>();
        services.AddTransient<IFirebirdDb<DegressiveMargin>, DegressiveMarginFirebirdDb>();
        services.AddTransient<IImporter<HIH>, HIHImporter>();
        services.AddTransient<IImporter<Patient>, PatientImporter>();
        services.AddTransient<IImporter<LoyaltyCard>, LoyaltyCardImporter>();
        services.AddTransient<IImporter<CommunicationSettings>, CommunicationSettingsImporter>();
        services.AddTransient<IImporter<Partner>, PartnerImporter>();
        services.AddTransient<IImporter<Product>, ProductImporter>();
        services.AddTransient<IImporter<PharmacyStock>, PharmacyStockImporter>();
        services.AddTransient<IImporter<DegressiveMargin>, DegressiveMarginImporter>();
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
        //var loyaltyCardImporter = provider.GetRequiredService<IImporter<LoyaltyCard>>();
        //loyaltyCardImporter.Import(); - v databazi se nachazi 2500000 musim zjistit zda se ma konvertovat
        var communicationSettingsImporter = provider.GetRequiredService<IImporter<CommunicationSettings>>();
            communicationSettingsImporter.Import();
        var partnerImporter = provider.GetRequiredService<IImporter<Partner>>();
            partnerImporter.Import();
        var productImporter = provider.GetRequiredService<IImporter<Product>>();
            productImporter.Import();
        var pharmacyStockImporter = provider.GetRequiredService<IImporter<PharmacyStock>>();
            pharmacyStockImporter.Import();
        var degressiveMarginImporter = provider.GetRequiredService<IImporter<DegressiveMargin>>();
            degressiveMarginImporter.Import();
        break;
    case "createdb":
        Console.WriteLine("Under construction!");
    break;
    default:
        Console.WriteLine($"Unknown option {args[1]}");
    break;
}
Console.ReadKey();


