using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.LxCatalogs
{
    public class LxCatalogFirebirdDb : FirebirdDbBase<LxCatalog>
    {
        const string sql = "insert into lxcatalog(id, name, l1code, l1name, l2code, l2name, l3code, l3name, l4code, l4name, l5code, l5name, l6code, l6name) " +
            "values (@Id, @Name, @L1Code, @L1Name, @L2Code, @L2Name, @L3Code, @L3Name, @L4Code, @L4Name, @L5Code, @L5Name, @L6Code, @L6Name)";
        public LxCatalogFirebirdDb(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
