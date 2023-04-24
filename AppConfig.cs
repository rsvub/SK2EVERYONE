using FirebirdSql.Data.FirebirdClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO.Compression;

namespace SK2EVERYONE
{
    public class AppConfig
    {
        static IHost host = Host.CreateDefaultBuilder().Build();
        static IConfiguration config = host.Services.GetRequiredService<IConfiguration>();

        public static string GetConnectionStringSourceSql()
        {
            //return config.GetConnectionString("SourceSqlDb");
            return config["ConnectionStrings:SourceSqlDb"];
        }
        public static string GetConnectionStringFirebird()
        {
            var firebirdPath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), "FireBird");
            if (!Directory.Exists(firebirdPath))
            {
                ZipFile.ExtractToDirectory(firebirdPath + ".zip", firebirdPath, false);
            }

            var dbPath = Path.Combine(firebirdPath,
                "FireBirdData",
                "SK2EVERYONE.FDB"
                //"My.FDB"
                );

            string fireBirdPath = Path.Combine(firebirdPath,
                "FireBirdServer",
                Environment.Is64BitOperatingSystem ? "64" : "32",
                "fbclient.dll");

            var connectionString = new FbConnectionStringBuilder
            {
                Database = dbPath,
                ServerType = FbServerType.Embedded,
                UserID = "SYSDBA",
                Password = "masterkey",
                ClientLibrary = fireBirdPath
            }.ToString();

            if (!File.Exists(dbPath))
            {
                FbConnection.CreateDatabase(connectionString);
            }

            return connectionString;
            //return config.GetConnectionString("FirebirdDb");
            //return config["ConnectionStrings:FirebirdDb"];
        }
    }
}
