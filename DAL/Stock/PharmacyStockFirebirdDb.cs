using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Stock
{
    public class PharmacyStockFirebirdDb : FirebirdDbBase<PharmacyStock>
    {
        const string sql = "insert into pharmacystock(Id, ProductCode, ProductId, ProductName, Quantity, Batch, BBD, ProductionPrice, PurchasePriceWithoutVAT, SellingPriceWithVAT, VAT, PurchaseDate, SellingDate, SupplierIDNumber, SupplierName) " +
            "values (@Id, @ProductCode, @ProductId, @ProductName, @Quantity, @Batch, @BBD, @ProductionPrice, @PurchasePriceWithoutVAT, @SellingPriceWithVAT, @VAT, @PurchaseDate, @SellingDate, @SupplierIDNumber, @SupplierName)";
        public PharmacyStockFirebirdDb(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
