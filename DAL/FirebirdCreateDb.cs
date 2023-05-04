using FirebirdSql.Data.FirebirdClient;
using System.IO.Compression;
using System.Reflection.PortableExecutable;

namespace SK2EVERYONE.DAL
{
    public class FirebirdCreateDb
    {

        public static void CreateFBDatabase()
        {
            
            var firebirdPath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), "FireBird");
            if (!Directory.Exists(firebirdPath))
            {
                ZipFile.ExtractToDirectory(firebirdPath + ".zip", firebirdPath, false);
            }

            var dbPath = Path.Combine(firebirdPath,
                "FireBirdData",
                "SK2EVERYONE.FDB"
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

            if (File.Exists(dbPath)) File.Delete(dbPath);
            FbConnection.CreateDatabase(connectionString);
            
        }
    }
}
