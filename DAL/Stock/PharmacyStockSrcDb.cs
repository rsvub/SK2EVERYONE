using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Stock
{
    public class PharmacyStockSrcDb : SrcDbBase<PharmacyStock>
    {
        const string sql = "SELECT T.ICI0000 AS Id, " +
            "T.KOC1100 AS ProductCode, " +
            "T3.ICI0000 AS ProductId, " +
            "T3.NAC1100 AS ProductName, " +
            "T.MNN3000 AS Quantity, " +
            "T.TXC1150 AS Batch, " +
            "T.DAD1150 AS BBD, " +
            "T.HON3824 AS ProductionPrice, " +
            "T.HON3051 AS PurchasePriceWithoutVAT, " +
            "T.HON3821 AS SellingPriceWithVAT, " +
            "DP.HON0650 AS VAT, " +
            "T.DAD3000 AS PurchaseDate, " +
            "T.DAD3001 AS SellingDate, " +
            "T4.KOC1200 AS SupplierIDNumber, " +
            "T4.NAC1200 AS SupplierName " +
            "FROM P00D3000 T " +
            "JOIN A00C1400 T2 on (T.ODI1400=T2.ICI0000) " +
            "JOIN P00C1100 T3 on (T3.ICI0000=T.ODI1100) AND (T3.ZNB1120=1) " +
            "JOIN A00C0650 DP ON (DP.ICI0000 = T3.ODI0650) " +
            "LEFT JOIN A00C1200 T4 on (T4.ICI0000=T.ODI1200) " +
            "JOIN A00C1000 T6 on (T2.ODI1000=T6.ICI0000) " + 
            "WHERE (IsNull(T.ZNB300000,0) = CONVERT(BIT, 0)) AND (T.MNN3000>0) AND (T6.ICI0000 in (339))";
        public PharmacyStockSrcDb(ISourceConnectionProvider connectionProvider) : base(sql, connectionProvider)
        {
        }
    }
}
