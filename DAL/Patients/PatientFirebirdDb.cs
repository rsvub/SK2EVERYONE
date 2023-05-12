using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Patients
{
    public class PatientFirebirdDb : FirebirdDbBase<Patient>
    {
        const string sql = "insert into patient(name, birthnumber, hihid, street, city, zipcode, phonenumber, mobilenumber) " +
            "values (@name, @birthnumber, @hihid, @street, @city, @zipcode, @phonenumber, @mobilenumber)";
        public PatientFirebirdDb(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
