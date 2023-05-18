namespace SK2EVERYONE.DAL.Partners
{
    public class CommunicationSettingsFirebirdCreateTable : FirebirdCreateTable
    {
        const string sql = "CREATE TABLE COMMUNICATIONSETTINGS " +
            "(ID INTEGER NOT NULL PRIMARY KEY," +
            "CODE VARCHAR(15), " +
            "DEFWSDL VARCHAR(200), " +
            "DEFURL VARCHAR(200), " +
            "DEFSVC VARCHAR(200), " +
            "DEFPRT VARCHAR(200), " +
            "TIMETOANSWER INTEGER, " +
            "CYCLETIME INTEGER, " +
            "MAXROW INTEGER, " +
            "DESCRIPTION VARCHAR(150), " +
            "ADDRESS VARCHAR(100), " +
            "B2BADDRESS VARCHAR(100))";
        public CommunicationSettingsFirebirdCreateTable(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
