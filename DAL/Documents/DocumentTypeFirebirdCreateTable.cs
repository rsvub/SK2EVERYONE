namespace SK2EVERYONE.DAL.Documents
{
    public class DocumentTypeFirebirdCreateTable : FirebirdCreateTable
    {
        const string sql = "create table documenttype ("
            + "id integer not null primary key, "
            + "name varchar(100), "
            + "type varchar(100))";
        public DocumentTypeFirebirdCreateTable(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
