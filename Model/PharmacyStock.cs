namespace SK2EVERYONE.Model
{
    public class PharmacyStock
    {
        public long Id { get; set; }
        public string ProductCode { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public double Quantity { get; set; }
        public string Batch { get; set; }
        public DateTime BBD { get; set; }
        public double ProductionPrice { get; set; }
        public double PurchasePriceWithoutVAT { get; set; }
        public double SellingPriceWithVAT { get; set; }
        public double VAT { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime SellingDate { get; set; }
        public string SupplierIDNumber { get; set; }
        public string SupplierName { get; set; }
    }
}
