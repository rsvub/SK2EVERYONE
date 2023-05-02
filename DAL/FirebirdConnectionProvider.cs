using FirebirdSql.Data.FirebirdClient;
using Microsoft.Extensions.Configuration;
using System.IO.Compression;

namespace SK2EVERYONE.DAL
{
    class FirebirdDb
    {
        public string FileName { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
    }
    public class FirebirdConnectionProvider : IFirebirdConnectionProvider, IDisposable
    {
        private readonly FbConnection connection;
        private readonly FirebirdDb settings;

        private string GetConnectionStringFirebird()
        {
            var firebirdPath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), "FireBird");
            if (!Directory.Exists(firebirdPath))
            {
                ZipFile.ExtractToDirectory(firebirdPath + ".zip", firebirdPath, false);
            }

            var dbPath = Path.Combine(firebirdPath,
                "FireBirdData",
                settings.FileName
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
        }
        public FirebirdConnectionProvider(IConfiguration config) 
        {
            settings = config.GetSection(nameof(FirebirdDb)).Get<FirebirdDb>();
            connection = new FbConnection(GetConnectionStringFirebird());
        }

        public FbConnection Connection => connection;
        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
