using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace SK2EVERYONE.DAL
{
    public interface IFirebirdDb<TModel> where TModel : class
    {
        void Insert<Tmodel>(object obj);
    }
    public abstract class FirebirdDbBase<Tmodel> : IFirebirdDb<Tmodel> where Tmodel : class
    {
        private readonly string sql;
        private readonly FbConnection connection;
        protected FirebirdDbBase(string sql, IFirebirdConnectionProvider firebirdConnectionProvider)
        {
            connection = firebirdConnectionProvider.Connection;
            this.sql = sql;
        }

        public void Insert<Tmodel>(object obj)
        {
            connection.Execute(sql, obj);
        }
    }
}
