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
using SK2EVERYONE.DAL.Partners;
using SK2EVERYONE.DAL.Products;
using SK2EVERYONE.DAL.Stock;
using SK2EVERYONE.DAL.Users;
using SK2EVERYONE.DAL.LxCatalogs;
using SK2EVERYONE.DAL.Documents;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddScoped<ISourceConnectionProvider, SourceConnectionProvider>();
        services.AddScoped<IFirebirdConnectionProvider, FirebirdConnectionProvider>();
        services.AddScoped<ICsvReaderProvider, CsvReaderProvider>();
        services.AddTransient<IFirebirdCreateDb, FirebirdCreateDb>();
        services.AddTransient<IFirebirdCreateTable, HIHFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, PatientFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, LoyaltyCardFirebirdCreateTable>(); // - musim doresit fk na jine tabulky (ano ci ne?)
        services.AddTransient<IFirebirdCreateTable, CommunicationSettingsFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, PartnerFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, ProductFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, ProductCodeFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, DeliveryCodeFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, PharmacyStockFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, DegressiveMarginFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, UserFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, DocumentTypeFirebirdCreateTable>();
        services.AddTransient<IFirebirdCreateTable, LxCatalogFirebirdCreateTable>();
        services.AddTransient<ISrcDb<HIH>, HIHSrcDb>();
        services.AddTransient<ISrcDb<Patient>, PatientSrcDb>();
        services.AddTransient<ISrcDb<LoyaltyCard>, LoyaltyCardSrcDb>();
        services.AddTransient<ISrcDb<CommunicationSettings>, CommunicationSettingsSrcDB>();
        services.AddTransient<ISrcDb<Partner>, PartnerSrcDb>();
        services.AddTransient<ISrcDb<Product>, ProductSrcDb>();
        services.AddTransient<ISrcDb<ProductCode>, ProductCodeSrcDb>();
        services.AddTransient<ISrcDb<DeliveryCode>, DeliveryCodeSrcDb>();
        services.AddTransient<ISrcDb<PharmacyStock>, PharmacyStockSrcDb>();
        services.AddTransient<ISrcDb<DegressiveMargin>, DegressiveMarginSrcDb>();
        services.AddTransient<ISrcDb<User>, UserSrcDb>();
        services.AddTransient<ISrcDb<DocumentType>, DocumentTypeSrcDb>();
        services.AddTransient<IFirebirdDb<HIH>, HIHFirebirdDb>();
        services.AddTransient<IFirebirdDb<Patient>, PatientFirebirdDb>();
        services.AddTransient<IFirebirdDb<LoyaltyCard>, LoyaltyCardFirebirdDb>();
        services.AddTransient<IFirebirdDb<CommunicationSettings>, CommunicationSettingsFirebirdDb>();
        services.AddTransient<IFirebirdDb<Partner>, PartnerFirebirdDb>();
        services.AddTransient<IFirebirdDb<Product>, ProductFirebirdDb>();
        services.AddTransient<IFirebirdDb<ProductCode>, ProductCodeFirebirdDb>();
        services.AddTransient<IFirebirdDb<DeliveryCode>, DeliveryCodeFirebirdDb>();
        services.AddTransient<IFirebirdDb<PharmacyStock>, PharmacyStockFirebirdDb>();
        services.AddTransient<IFirebirdDb<DegressiveMargin>, DegressiveMarginFirebirdDb>();
        services.AddTransient<IFirebirdDb<User>, UserFirebirdDb>();
        services.AddTransient<IFirebirdDb<DocumentType>, DocumentTypeFirebirdDb>();
        services.AddTransient<IFirebirdDb<LxCatalog>, LxCatalogFirebirdDb>();
        services.AddTransient<IImporter<HIH>, HIHImporter>();
        services.AddTransient<IImporter<Patient>, PatientImporter>();
        services.AddTransient<IImporter<LoyaltyCard>, LoyaltyCardImporter>();
        services.AddTransient<IImporter<CommunicationSettings>, CommunicationSettingsImporter>();
        services.AddTransient<IImporter<Partner>, PartnerImporter>();
        services.AddTransient<IImporter<Product>, ProductImporter>();
        services.AddTransient<IImporter<ProductCode>, ProductCodeImporter>();
        services.AddTransient<IImporter<DeliveryCode>, DeliveryCodeImporter>();
        services.AddTransient<IImporter<PharmacyStock>, PharmacyStockImporter>();
        services.AddTransient<IImporter<DegressiveMargin>, DegressiveMarginImporter>();
        services.AddTransient<IImporter<User>, UserImporter>();
        services.AddTransient<IImporter<DocumentType>, DocumentTypeImporter>();
        services.AddTransient<ISrcCsv<LxCatalog>, LxCatalogSrcCsv>();
        services.AddTransient<ICsvImporter<LxCatalog>, LxCatalogCsvImporter>();
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
        var productCodeImporter = provider.GetRequiredService<IImporter<ProductCode>>();
            productCodeImporter.Import();
        var deliveryCodeImporter = provider.GetRequiredService<IImporter<DeliveryCode>>();
            deliveryCodeImporter.Import();
        var pharmacyStockImporter = provider.GetRequiredService<IImporter<PharmacyStock>>();
            pharmacyStockImporter.Import();
        var degressiveMarginImporter = provider.GetRequiredService<IImporter<DegressiveMargin>>();
            degressiveMarginImporter.Import();
        var userImporter = provider.GetRequiredService<IImporter<User>>();
            userImporter.Import();
        var documentTypeImporter = provider.GetRequiredService<IImporter<DocumentType>>();
            documentTypeImporter.Import();
        var lxCatalog = provider.GetRequiredService<ICsvImporter<LxCatalog>>();
            lxCatalog.CsvImport();
    break;
    case "createdb":
        Console.WriteLine("Under construction!");
    break;
    default:
        Console.WriteLine($"Unknown option {args[1]}");
    break;
}
Console.WriteLine("Press any key to exit");
Console.ReadKey();


