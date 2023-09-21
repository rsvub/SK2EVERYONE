using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Stock
{
    public class TransactionSrcDb : SrcDbBase<Transaction>
    {
        const string sql = "SELECT CP.KOC0701 AS Id, " +
            "PSK.DAD3200 AS TransactionDate, " +
            "SubString(DD.TXC0702,1,1) AS TypeOfMovement, " +
            "PSK.MNN3200 AS Quantity, " +
            "KDD.CII0750 AS DocumentId, " +
            "IsNull (TFD.ICI0000, 1) AS DocumentTypeId, " +
            "TFD.NAC0741 AS DocumentTypeName, " +
            "KR.CII0350 AS PrescriptionId, " +
            "TY.ICI0000 AS ProductId, " +
            "TY.NAC1100 AS ProductName, " +
            "TY.KOC1100 AS ProductCode, " +
            "PSK.ODI3000 AS PharmacyStockId, " +
            "PSD.MNN3000 AS PharmacyStockQuantity " +
            "FROM P00D3200 PSK " +
            "LEFT JOIN (P00C0701 CP JOIN P00C0702 DD ON (DD.ICI0000=CP.ODI0702)) ON (CP.ICI0000=PSK.ODI0701) " +
            "LEFT JOIN A00D0750 KDD on (KDD.ICI0000=PSK.ODI0750) " +
            "LEFT JOIN A00S0741 TFD on (TFD.ICI0000=KDD.ODI0741) " +
            "JOIN P00C1100  TY ON (PSK.ODI1100 = TY.ICI0000) " +
            "LEFT JOIN A00D0350 KR on (KR.ICI0000=PSK.ODI0350) " +
            "LEFT JOIN P00D3000 PSD on (PSD.ICI0000=PSK.ODI3000) " +
            "WHERE PSD.MNN3000>0";
        public TransactionSrcDb(ISourceConnectionProvider connectionProvider) : base(sql, connectionProvider)
        {
        }
    }
}
