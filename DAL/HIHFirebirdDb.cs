
namespace SK2EVERYONE.DAL
{
    public class HIHFirebirdDb : FirebirdDbBase
    {
        const string sql = "insert into hih(id, name, region, idwithoutregion) values (@id, @name, @region, @idwithoutregion)";
        public HIHFirebirdDb(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
