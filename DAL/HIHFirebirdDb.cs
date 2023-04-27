﻿using FirebirdSql.Data.FirebirdClient;
using Microsoft.Extensions.Configuration;
using SK2EVERYONE.Model;
using System.IO.Compression;

namespace SK2EVERYONE.DAL
{
    class FirebirdDb
    {
        public string FileName { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
    }

    public interface IHIHFirebirdDb
    {
        public void InsertHIH(HIH hih);
    }

    public class HIHFirebirdDb : IHIHFirebirdDb, IDisposable
    {
        private readonly FirebirdDb settings;

        private readonly FbConnection con;
        private readonly FbCommand cmd;
        public HIHFirebirdDb(IConfiguration config)
        {
            settings = config.GetSection(nameof(FirebirdDb)).Get<FirebirdDb>();
            con = new FbConnection(GetConnectionStringFirebird());
            con.Open();

            cmd = new FbCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into hih(id, name, region, idwithoutregion) values (@id, @name, @region, @idwithoutregion)";
            cmd.Parameters.Add("@id", FbDbType.VarChar);
            cmd.Parameters.Add("@name", FbDbType.VarChar);
            cmd.Parameters.Add("@region", FbDbType.VarChar);
            cmd.Parameters.Add("@idwithoutregion", FbDbType.VarChar);
        }

        public void Dispose()
        {
            con.Dispose();
        }

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
        }

        public void InsertHIH(HIH hih)
        {
            try
            {
                cmd.Parameters["@id"].Value = hih.Id;
                cmd.Parameters["@name"].Value = hih.Name;
                cmd.Parameters["@region"].Value = hih.Region;
                cmd.Parameters["@idwithoutregion"].Value = hih.IdWithoutRegion;
                cmd.ExecuteNonQuery();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.GetType().FullName);
                Console.WriteLine(ex.Message);
            }
        }
    }
}