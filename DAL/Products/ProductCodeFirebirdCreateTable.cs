namespace SK2EVERYONE.DAL.Products
{
    public class ProductCodeFirebirdCreateTable : FirebirdCreateTable
    {
        const string sql = "CREATE TABLE PRODUCTCODE " +
            "(ID INTEGER NOT NULL PRIMARY KEY, " +
            "CODE VARCHAR(40), " +
            "CODETYPEID INTEGER, " +
            "CODETYPENAME VARCHAR(30), " +
            "CODEGROUPID INTEGER, " +
            "CODEGROUPNAME VARCHAR(30), " +
            "ISINTERNAL INTEGER, " +
            "PRODUCTNAME VARCHAR(100), " +
            "PRODUCTID INTEGER, " +
            "CONSTRAINT FK_ProductCode_Product FOREIGN KEY(PRODUCTID) REFERENCES PRODUCT(ID) ON DELETE NO ACTION ON UPDATE CASCADE)";
        public ProductCodeFirebirdCreateTable(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
