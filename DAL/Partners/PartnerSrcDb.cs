using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Partners
{
    public class PartnerSrcDb : SrcDbBase<Partner>
    {
        const string sql = "SELECT T1.ICI0000 As Id, " +
            "T1.NAC1201 AS Name, " +
            "T1.NAC1202 AS City, " +
            "T1.NAC1203 AS Street, " +
            "T1.NAC1204 AS ZipCode, " +
            "T3.NAC1230 AS IDNumber, " +
            "T3.NAC1231 AS VATNumber, " +
            "T3.NAC1232 AS VATNumberWithoutSK, " +
            "T3.ZNB1226 AS PayerOfVat, " +
            "T1.NAC1207 AS AccountNumber, " +
            "T1.NAC1208 AS Bank, " +
            "T1.CIC1202 AS Phone, " +
            "T1.CIC1203 AS Fax, " +
            "T1.CIC1204 AS MobilePhone, " +
            "T1.NAC1205 AS Email, " +
            "T1.NAC1206 AS WWW, " +
            "ISNULL(T1.ODI2222, 1) AS CommunicationId, " +
            "T15.KOC1215 AS CommunicationCode, " +
            "T2.NAC120401 AS GroupType, " +
            "F0.ZNB1208 AS Subscriber, " +
            "F0.ZNB1209 AS Supplier " +
            "FROM A00C1200 T1 " +
            "LEFT JOIN A00C120201 T3 ON (T1.ODI120201 = T3.ICI0000) " +
            "LEFT JOIN A00C2222 T15 ON (T15.ICI0000 = T1.ODI2222) " +
            "LEFT JOIN A00C120401 T2 ON (T1.ODI120401 = T2.ICI0000) " +
            "JOIN A00C2221 F0 ON (F0.ODI1200 = T1.ICI0000) ";
        public PartnerSrcDb(ISourceConnectionProvider connectionProvider) : base(sql, connectionProvider)
        {
        }
    }
}
