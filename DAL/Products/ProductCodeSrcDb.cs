using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Products
{
    public class ProductCodeSrcDb : SrcDbBase<ProductCode>
    {
        const string sql = "SELECT T1.ICI0000 As Id, " +
            "T1.KOC2900 As Code, " +
            "TK.ICI0000 As CodeTypeId, " +
            "TK.NAC2901 AS CodeTypeName, " +
            "KK.ICI0000 As CodeGroupId, " +
            "KK.NAC2903 AS CodeGroupName, " +
            "T2.ZNB2900 As IsInternal, " +
            "T3.NAC1100 As ProductName, " +
            "T1.ODI1100 As ProductId " +
            "FROM P00C2900 T1 " +
            "JOIN (P00C2902 T2 JOIN P00C2901 TK ON (TK.ICI0000=T2.ODI2901) JOIN P00C2903 KK ON (KK.ICI0000=T2.ODI2903)) ON T2.ICI0000 = T1.ODI2902 " +
            "JOIN P00C1100 T3 ON T3.ICI0000 = T1.ODI1100";
        public ProductCodeSrcDb(ISourceConnectionProvider connectionProvider) : base(sql, connectionProvider)
        {
        }
    }
}
