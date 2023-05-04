
using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL
{
    public class HIHFirebirdCreateTable : FirebirdCreateTable<HIH>
    {
        const string sql = "CREATE TABLE HIH (ID VARCHAR(20) NOT NULL PRIMARY KEY, NAME VARCHAR(50), REGION VARCHAR(50), IDWITHOUTREGION VARCHAR(20))";
        public HIHFirebirdCreateTable(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
