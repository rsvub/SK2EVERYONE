using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Users
{
    public class UserSrcDb : SrcDbBase<User>
    {
        const string sql = "SELECT CZ.ICI0000 As Id, " +
            "CZ.KOC0910 As Code, " +
            "CZ.NAC0910 As Name, " +
            "CZ.TXC0910 As Role, " +
            "CZ.TXC0911 As Email, " +
            "CZ.ZNB0910 As IsActive, " +
            "CZ.ZNB0911 As IsResponsiblePharmacist, " +
            "CZ.ZNB0912 As IsPharmacist, " +
            "CZ.ZNB0913 As IsLaboratoryAssistant FROM A00C0910 CZ";
        public UserSrcDb(ISourceConnectionProvider connectionProvider) : base(sql, connectionProvider)
        {
        }
    }
}
