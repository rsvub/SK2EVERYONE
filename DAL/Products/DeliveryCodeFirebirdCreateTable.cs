namespace SK2EVERYONE.DAL.Products
{
    public class DeliveryCodeFirebirdCreateTable : FirebirdCreateTable
    {
        const string sql = "CREATE TABLE DELIVERYCODE " +
            "(ID INTEGER NOT NULL PRIMARY KEY, " +
            "PRODUCTID INTEGER, " +
            "CODE VARCHAR(50), " +
            "PARTNERID INTEGER, " +
            "ISACTIVE INTEGER, " +
            "CONSTRAINT FK_DeliveryCode_Product FOREIGN KEY (PRODUCTID) REFERENCES PRODUCT(ID) ON DELETE NO ACTION ON UPDATE CASCADE, " +
            "CONSTRAINT FK_DeliveryCode_Partner FOREIGN KEY (PARTNERID) REFERENCES PARTNER(ID) ON DELETE NO ACTION ON UPDATE CASCADE)";
        public DeliveryCodeFirebirdCreateTable(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
