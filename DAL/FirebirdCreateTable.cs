using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace SK2EVERYONE.DAL
{
    public interface IFirebirdCreateTable
    {
        void Create();
    }

    public abstract class FirebirdCreateTable : IFirebirdCreateTable
    {
        private readonly string sql;
        private readonly FbConnection connection;
        protected FirebirdCreateTable(string sql, IFirebirdConnectionProvider firebirdConnectionProvider)
        {
            connection = firebirdConnectionProvider.Connection;
            this.sql = sql;
        }
        public void Create()
        {
            Console.WriteLine(sql);
            Console.ReadKey();
            connection.Execute(sql);
        }
    }
}
