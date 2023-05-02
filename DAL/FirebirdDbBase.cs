using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace SK2EVERYONE.DAL
{
    public interface IFirebirdDb
    {
        void Insert(object obj);
    }
    public abstract class FirebirdDbBase : IFirebirdDb
    {
        private readonly string sql;
        private readonly FbConnection connection;
        protected FirebirdDbBase(string sql, IFirebirdConnectionProvider firebirdConnectionProvider)
        {
            connection = firebirdConnectionProvider.Connection;
            this.sql = sql;
        }
        public void Insert(object obj)
        {
            connection.Execute(sql, obj);
        }
    }
}
