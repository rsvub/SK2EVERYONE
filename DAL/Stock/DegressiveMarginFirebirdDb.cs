using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Stock
{
    public class DegressiveMarginFirebirdDb : FirebirdDbBase<DegressiveMargin>
    {
        const string sql = "insert into degressivemargin(id, valuefrom, distributoramount, distributorpercentage, pharmacyamount, pharmacypercentage) values (@id, @valuefrom, @distributoramount, @distributorpercentage, @pharmacyamount, @pharmacypercentage)";
        public DegressiveMarginFirebirdDb(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
