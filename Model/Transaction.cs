namespace SK2EVERYONE.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TypeOfMovement { get; set; }
        public double Quantity { get; set; }
        public long DocumentId { get; set; }
        public int DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public int PrescriptionId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int PharmacyStockId { get; set; }
        public double PharmacyStockQuantity { get; set; }
    }
}
