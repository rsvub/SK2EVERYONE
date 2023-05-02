using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace SK2EVERYONE.DAL
{
    public class SourceConnectionProvider : ISourceConnectionProvider, IDisposable
    {
        private readonly SqlConnection connection;

        public SourceConnectionProvider(IConfiguration config)
        {
            var connectionStringSourceSql = config.GetConnectionString("SourceSqlDb");
            connection = new SqlConnection(connectionStringSourceSql);
        }

        public SqlConnection Connection => connection;

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}