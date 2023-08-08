namespace SK2EVERYONE.DAL.LxCatalogs
{
    public class LxCatalogFirebirdCreateTable : FirebirdCreateTable
    {
        const string sql = "CREATE TABLE LXCATALOG " +
            "(ID VARCHAR(20) NOT NULL PRIMARY KEY, " +
            "NAME VARCHAR(120), " +
            "L1CODE VARCHAR(20), " +
            "L1NAME VARCHAR(120), " +
            "L2CODE VARCHAR(20), " +
            "L2NAME VARCHAR(120), " +
            "L3CODE VARCHAR(20), " +
            "L3NAME VARCHAR(120), " +
            "L4CODE VARCHAR(20), " +
            "L4NAME VARCHAR(120), " +
            "L5CODE VARCHAR(20), " +
            "L5NAME VARCHAR(120), " +
            "L6CODE VARCHAR(20), " +
            "L6NAME VARCHAR(120))";
        public LxCatalogFirebirdCreateTable(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
