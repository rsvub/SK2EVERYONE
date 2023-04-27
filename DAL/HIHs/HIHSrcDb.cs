using Dapper;
using Microsoft.Extensions.Configuration;
using SK2EVERYONE.Model.HIHs;
using System.Data.SqlClient;

namespace SK2EVERYONE.DAL.HIHs
{
    public interface ISrcDb<TModel> where TModel : class
    {
        IEnumerable<TModel> GetAll();
    }

    public class HIHSrcDb : SrcDbBase<HIH>
    {
        const string sql = "SELECT T.KOC0441 AS Id, T.NAC044101 As Name, T.NAC044102 As Region, T3.KOC0440 As IdWithoutRegion FROM A00C0441 T LEFT JOIN A00C0440 T3 ON(T3.ICI0000 = T.ODI0440)";
        public HIHSrcDb(IConfiguration config):base(sql, config)
        {
        }
    }

    public class ModelToRemoveSrcDB : SrcDbBase<ModelToRemove>
    {
        const string sql = "SELECT T.KOC0441 AS Id, T.NAC044101 As Name, T.NAC044102 As Description FROM A00C0441 T";
        public ModelToRemoveSrcDB(IConfiguration config) : base(sql, config)
        {
        }
    }

    public abstract class SrcDbBase<TModel> : ISrcDb<TModel>, IDisposable where TModel: class
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

