using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace SK2EVERYONE.DAL
{
    public interface IFirebirdDb<TModel> where TModel : class
    {
        void Insert(TModel obj);
    }
    public abstract class FirebirdDbBase<TModel> : IFirebirdDb<TModel> where TModel : class
    {
        private readonly string sql;
        private readonly FbConnection connection;
        protected FirebirdDbBase(string sql, IFirebirdConnectionProvider firebirdConnectionProvider)
        {
            connection = firebirdConnectionProvider.Connection;
            this.sql = sql;
        }

        public void Insert(TModel obj)
        {
            connection.Execute(sql, obj);
        }
    }
}
