using Dapper;
using System.Data.SqlClient;

namespace SK2EVERYONE.DAL
{
    public interface ISrcDb<TModel> where TModel : class
    {
        IEnumerable<TModel> GetAll();
    }

    public abstract class SrcDbBase<TModel> : ISrcDb<TModel> where TModel : class
    {
        private readonly string sql;

        private readonly SqlConnection connection;
        protected SrcDbBase(string sql, ISourceConnectionProvider connectionProvider)
        {
            connection = connectionProvider.Connection;
            this.sql = sql;
        }

        public IEnumerable<TModel> GetAll()
        {
            return connection.Query<TModel>(sql);
        }
    }
}