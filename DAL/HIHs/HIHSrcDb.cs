using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SK2EVERYONE.Model.HIHs;
using System.Data.SqlClient;

namespace SK2EVERYONE.DAL.HIHs
{
    public interface IHIHSrcDb
    {
        IEnumerable<HIH> GetAllHIH();
    }

    public class HIHSrcDb : IHIHSrcDb, IDisposable
    {
        const string sql = "SELECT T.KOC0441 AS Id, T.NAC044101 As Name, T.NAC044102 As Region, T3.KOC0440 As IdWithoutRegion FROM A00C0441 T LEFT JOIN A00C0440 T3 ON(T3.ICI0000 = T.ODI0440)";
        
        private readonly string connectionStringSourceSql;

        private readonly SqlConnection connection;
        public HIHSrcDb(IConfiguration config, ILogger<HIHSrcDb> logger) 
        {
            connectionStringSourceSql = config.GetConnectionString("SourceSqlDb");
            connection = new SqlConnection(connectionStringSourceSql);
            logger.LogInformation(connectionStringSourceSql);
        }

        public void Dispose()
        {
            connection?.Dispose();
        }

        public IEnumerable<HIH> GetAllHIH()
        {
            return connection.Query<HIH>(sql);
        }
    }
}

