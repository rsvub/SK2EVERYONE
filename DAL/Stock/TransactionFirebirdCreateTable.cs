namespace SK2EVERYONE.DAL.Stock
{
    public class TransactionFirebirdCreateTable : FirebirdCreateTable
    {
        const string sql = "CREATE TABLE TRANSACTION " +
            "(ID INTEGER NOT NULL, " +
            "TRANSACTIONDATE DATE, " +
            "TYPEOFMOVEMENT VARCHAR(1), " +
            "QUANTITY FLOAT, " +
            "DOCUMENTID INT128, " +
            "DOCUMENTTYPEID INTEGER, " +
            "DOCUMENTTYPENAME VARCHAR(30), " +
            "PRESCRIPTIONID INTEGER, " +
            "PRODUCTID INTEGER, " +
            "PRODUCTNAME VARCHAR(100), " +
            "PRODUCTCODE VARCHAR(30), " +
            "PHARMACYSTOCKID INTEGER, " +
            "PHARMACYSTOCKQUANTITY FLOAT, " +
            "CONSTRAINT FK_Transaction_PharmacyStock FOREIGN KEY(PHARMACYSTOCKID) REFERENCES PHARMACYSTOCK(ID) ON DELETE NO ACTION ON UPDATE CASCADE, " +
            "CONSTRAINT FK_Transaction_Product FOREIGN KEY(PRODUCTID) REFERENCES PRODUCT(ID) ON DELETE NO ACTION ON UPDATE CASCADE, " +
            "CONSTRAINT FK_Transaction_DocumentType FOREIGN KEY(DOCUMENTTYPEID) REFERENCES DOCUMENTTYPE(ID) ON DELETE NO ACTION ON UPDATE CASCADE)";
        public TransactionFirebirdCreateTable(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
