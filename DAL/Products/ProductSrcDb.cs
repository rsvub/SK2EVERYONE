using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Products
{
    public class ProductSrcDb : SrcDbBase<Product>
    {
        const string sql = "SELECT T.ICI0000 AS Id, " +
            "T.ZNB1122 AS SalesActive, " +
            "T.ZNB1123 AS DeliveriesActive, " +
            "T.NAC1100 AS Name, " +
            "T.NAC1101 AS NameSuplement, " +
            "T.KOC1100 AS Code, " +
            "SUKL.KOC2900 AS Sukl, " +
            "A1.KOC110501 AS ATC, " +
            "EAN.KOC2900 AS EAN, " +
            "ADC.KOC2900 AS ADC, " +
            "T.ZNC1110 AS Composition, " +
            "T.MNN1120 AS AmountOfOpiate, " +
            "P2.NAC110201 AS Type, " +
            "P1.KOC110101 AS ManufacturerId, " +
            "P1.NAC110101 AS ManufacturerName, " +
            "T.NAC1150 AS Country, " +
            "T2.HON0650 AS Vat, " +
            "T.HON1136 AS Markup, " +
            "T.ZNC1115 AS IsDrug, " +
            "T.ZNC1114 AS SuklCondition, " +
            "T.TXC1102 AS Category, " +
            "T.ZNI1102 AS TypeOfReimbursement, " +
            "T.TXC1110 AS PrescribingRestrictions, " +
            "T.MNN1101 AS MinimumOrder, " +
            "T.MNN1100 AS MinimumStock, " +
            "T.MNN1110 AS OptimumStock, " +
            "T.ZNB1137 AS CannotOrder, " +
            "T.ZNB2960 AS ConsignmentStock, " +
            "T9.KOC2970 AS Unit, " +
            "KCS.KOC2900 AS CustomsTariff, " +
            "T.ZNB1157 AS FMD, " +
            "T.ZNB1147 AS PlanningWizard, " +
            "T.HON1114 AS TaxaLaborum " +
            "FROM P00C1100 T " +
            "LEFT JOIN P00C2900 SUKL ON ((SUKL.ODI2901=3) AND (T.ICI0000=SUKL.ODI1100)) " +
            "LEFT JOIN P00C110501 A1 ON (T.ODI110501=A1.ICI0000) " +
            "LEFT JOIN P00C2900 EAN ON (EAN.ODI1100 = T.ICI0000) AND (EAN.ODI2901 = 9) " +
            "LEFT JOIN P00C2900 ADC ON ((ADC.ODI2901=12) AND (T.ICI0000=ADC.ODI1100)) " +
            "LEFT JOIN P00C110201 P2 ON (T.ODI110201=P2.ICI0000) " +
            "LEFT JOIN P00C110101 P1 ON (T.ODI110101=P1.ICI0000) " +
            "LEFT JOIN A00C0650 T2 ON (T.ODI0650=T2.ICI0000) " +
            "LEFT JOIN P00C2970 T9 ON (T.ODI2970=T9.ICI0000) " +
            "LEFT JOIN P00C2900 KCS ON (KCS.ODI1100 = T.ICI0000) AND (KCS.ODI2901 = 8)";
        public ProductSrcDb(ISourceConnectionProvider connectionProvider) : base(sql, connectionProvider)
        {
        }
    }
}
