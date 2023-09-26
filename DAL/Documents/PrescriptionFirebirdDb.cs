using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Documents
{
    public class PrescriptionFirebirdDb : FirebirdDbBase<Prescription>
    {
        const string sql = "insert into prescription(id, documentid, nationalidentificationnumber, idepresrciption, hihidwithoutregion) " +
            "values (@id, @documentid, @nationalidentificationnumber, @idepresrciption, @hihidwithoutregion)";
        public PrescriptionFirebirdDb(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
