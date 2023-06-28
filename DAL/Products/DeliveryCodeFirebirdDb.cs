using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Products
{
    public class DeliveryCodeFirebirdDb : FirebirdDbBase<DeliveryCode>
    {
        const string sql = "insert into deliverycode(id, code, productid, partnerid, isactive) " +
            "values (@id, @code, @productid, @partnerid, @isactive)";
        public DeliveryCodeFirebirdDb(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
