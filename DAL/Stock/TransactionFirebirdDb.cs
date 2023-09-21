using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Stock
{
    public class TransactionFirebirdDb : FirebirdDbBase<Transaction>
    {
        const string sql = "insert into transaction(Id, TransactionDate, TypeOfMovement, Quantity, DocumentId, DocumentTypeId, DocumentTypeName, PrescriptionId, ProductId, ProductName, ProductCode, PharmacyStockId, PharmacyStockQuantity) " +
            "values (@Id, @TransactionDate, @TypeOfMovement, @Quantity, @DocumentId, @DocumentTypeId, @DocumentTypeName, @PrescriptionId, @ProductId, @ProductName, @ProductCode, @PharmacyStockId, @PharmacyStockQuantity)";
        public TransactionFirebirdDb(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
