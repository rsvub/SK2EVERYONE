using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Stock
{
    public class DegressiveMarginSrcDb : SrcDbBase<DegressiveMargin>
    {
        const string sql = "SELECT ICI0000 AS Id, HON2031 As ValueFrom, HON203100 As DistributorAmount, CIN203100 As DistributorPercentage, HON203101 As PharmacyAmount, CIN203101 As PharmacyPercentage FROM P00C2031";
        public DegressiveMarginSrcDb(ISourceConnectionProvider connectionProvider) : base(sql, connectionProvider)
        {
        }
    }
}
