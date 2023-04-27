using Dapper;
using Microsoft.Extensions.Configuration;
using SK2EVERYONE.Model;
using System.Data.SqlClient;

namespace SK2EVERYONE.DAL
{
    public interface ISrcDb<TModel> where TModel : class
    {
        IEnumerable<TModel> GetAll();
    }

    public abstract class SrcDbBase<TModel> : ISrcDb<TModel>, IDisposable where TModel : class
    {
        private readonly string sql;

        private readonly string connectionStringSourceSql;

        private readonly SqlConnection connection;
        protected SrcDbBase(string sql, IConfiguration config)
        {
            connectionStringSourceSql = config.GetConnectionString("SourceSqlDb");
            connection = new SqlConnection(connectionStringSourceSql);
            this.sql = sql;
        }

        public void Dispose()
        {
            connection?.Dispose();
        }
        public IEnumerable<TModel> GetAll()
        {
            return connection.Query<TModel>(sql);
        }
    }
}