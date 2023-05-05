
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace SK2EVERYONE.DAL
{
    public interface IFirebirdCreateTable<Tmodel> where Tmodel : class
    {
        void Create<Tmodel>();
    }
    public abstract class FirebirdCreateTable<Tmodel> : IFirebirdCreateTable<Tmodel> where Tmodel : class
    {
        private readonly string sql;
        private readonly FbConnection connection;
        protected FirebirdCreateTable(string sql, IFirebirdConnectionProvider firebirdConnectionProvider)
        {
            connection = firebirdConnectionProvider.Connection;
            this.sql = sql;
        }
        public void Create<Tmodel>()
        {
            Console.WriteLine(sql);
            Console.ReadKey();
            connection.Execute(sql);
        }
    }
}
