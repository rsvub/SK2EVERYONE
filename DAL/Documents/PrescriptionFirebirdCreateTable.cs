namespace SK2EVERYONE.DAL.Documents
{
    public class PrescriptionFirebirdCreateTable : FirebirdCreateTable
    {
        const string sql = "create table prescription ("
            + "id integer, "
            + "documentid integer, "
            + "nationalidentificationnumber varchar(20), "
            + "idepresrciption varchar(30), "
            + "hihidwithoutregion integer)";
        public PrescriptionFirebirdCreateTable(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
