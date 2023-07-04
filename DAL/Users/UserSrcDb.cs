using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Users
{
    public class UserSrcDb : SrcDbBase<User>
    {
        const string sql = "SELECT CZ.ICI0000, CZ.KOC0910, CZ.NAC0910, CZ.TXC0910, CZ.ZNB0910, CZ.ZNB0911, CZ.ZNB0912, CZ.ZNB0913, CZ.TXC0911 FROM A00C0910 CZ";
        public UserSrcDb(ISourceConnectionProvider connectionProvider) : base(sql, connectionProvider)
        {
        }
    }
}
