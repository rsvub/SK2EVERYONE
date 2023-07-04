using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Users
{
    public class UserFirebirdDb : FirebirdDbBase<User>
    {
        const string sql = "insert into user(Id, Code, Name, Role, Email, IsActive, IsResponsiblePharmacist, IsPharmacist, IsLaboratoryAssistant) " +
            "values (@Id, @Code, @Name, @Role, @Email, @IsActive, @IsResponsiblePharmacist, @IsPharmacist, @IsLaboratoryAssistant)";
        public UserFirebirdDb(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
