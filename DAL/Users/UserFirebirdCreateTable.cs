namespace SK2EVERYONE.DAL.Users
{
    public class UserFirebirdCreateTable : FirebirdCreateTable
    {
        const string sql = "CREATE TABLE USER " +
            "(ID INTEGER NOT NULL PRIMARY KEY, " +
            "CODE VARCHAR(10), " +
            "NAME VARCHAR(50), " +
            "ROLE VARCHAR(50), " +
            "EMAIL VARCHAR(50), " +
            "ISACTIVE INTEGER, " +
            "IsResponsiblePharmacist INTEGER, " +
            "IsPharmacist INTEGER, " +
            "IsLaboratoryAssistant INTEGER)";
        public UserFirebirdCreateTable(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
