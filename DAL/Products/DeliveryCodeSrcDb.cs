using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Products
{
    public class DeliveryCodeSrcDb : SrcDbBase<DeliveryCode>
    {
        const string sql = "SELECT IK.ICI0000 AS Id, " +
            "CP.ICI0000 AS ProductId, " +
            "IK.KOC2930 AS Code, " +
            "IK.ODI1200 AS PartnerId, " +
            "IK.ZNB2930 AS IsActive " +
            "FROM P00C2930 IK " +
            "JOIN P00C1100 CP ON (CP.ICI0000 = IK.ODI1100)";
        public DeliveryCodeSrcDb(ISourceConnectionProvider connectionProvider) : base(sql, connectionProvider)
        {
        }
    }
}
