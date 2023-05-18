
using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.LoyaltyCards
{
    public class LoyaltyCardFirebirdDb : FirebirdDbBase<LoyaltyCard>
    {
        const string sql = "insert into loyaltycard(CardNumber, CardBarCode, CardType, Active, OtcPoint, RxPoint, Sex, Surname, Name, Street, City, ZipCode, Email, Phone, Education, Industry, Employment, Title, Note, DateOfBirth, UnitId, PhysicianId) " +
            "values (@CardNumber, @CardBarCode, @CardType, @Active, @OtcPoint, @RxPoint, @Sex, @Surname, @Name, @Street, @City, @ZipCode, @Email, @Phone, @Education, @Industry, @Employment, @Title, @Note, @DateOfBirth, @UnitId, @PhysicianId)";
        public LoyaltyCardFirebirdDb(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
