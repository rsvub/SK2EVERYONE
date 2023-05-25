namespace SK2EVERYONE.DAL.Products
{
    public class ProductFirebirdCreateTable : FirebirdCreateTable
    {
        const string sql = "CREATE TABLE PRODUCT " +
            "(ID INTEGER NOT NULL PRIMARY KEY, " +
            "SALESACTIVE INTEGER, " +
            "DELIVERIESACTIVE INTEGER, " +
            "NAME VARCHAR(100), " +
            "NAMESUPLEMENT VARCHAR(10), " +
            "CODE VARCHAR(30), " +
            "SUKL VARCHAR(40), " +
            "ATC VARCHAR(10), " +
            "EAN VARCHAR(40), " +
            "ADC VARCHAR(40), " +
            "COMPOSITION CHAR(1), " +
            "AMOUNTOFOPIATE FLOAT, " +
            "TYPE VARCHAR(30), " +
            "MANUFACTURERID VARCHAR(15), " +
            "MANUFACTURERNAME VARCHAR(100), " +
            "COUNTRY VARCHAR(3), " +
            "VAT FLOAT, " +
            "MARKUP FLOAT, " +
            "ISDRUG VARCHAR(2), " +
            "SUKLCONDITION CHAR(1), " +
            "CATEGORY VARCHAR(2), " +
            "TYPEOFREIMBURSEMENT INTEGER, " +
            "PRESCRIBINGRESTRICTIONS VARCHAR(100), " +
            "MINIMUMORDER FLOAT, " +
            "MINIMUMSTOCK FLOAT, " +
            "OPTIMUMSTOCK FLOAT, " +
            "CANNOTORDER INTEGER, " +
            "CONSIGNMENTSTOCK INTEGER, " +
            "UNIT VARCHAR(15), " +
            "CUSTOMSTARIFF VARCHAR(40), " +
            "FMD INTEGER, " +
            "PLANNINGWIZARD INTEGER, " +
            "TAXALABORUM FLOAT)";
        public ProductFirebirdCreateTable(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
