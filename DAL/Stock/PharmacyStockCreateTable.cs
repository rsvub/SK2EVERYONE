namespace SK2EVERYONE.DAL.Stock
{
    public class PharmacyStockCreateTable : FirebirdCreateTable
    {
        const string sql = "CREATE TABLE PHARMACYSTOCK " +
            "(ID INTEGER NOT NULL PRIMARY KEY, " +
            "PRODUCTCODE VARCHAR(30), " +
            "PRODUCTID INTEGER, " +
            "PRODUCTNAME VARCHAR(100), " +
            "QUANTITY FLOAT, " +
            "BATCH VARCHAR(30), " +
            "BBD DATE, " +
            "PRODUCTIONPRICE FLOAT, " +
            "PURCHASEPRICEWITHOUTVAT FLOAT, " +
            "SELLINGPRICEWITHVAT FLOAT, " +
            "VAT FLOAT, " +
            "PURCHASEDATE DATE, " +
            "SELLINGDATE DATE, " +
            "SUPPLIERIDNUMBER VARCHAR(15), " +
            "SUPPLIERNAME VARCHAR(100))";
        public PharmacyStockCreateTable(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
