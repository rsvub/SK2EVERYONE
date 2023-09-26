using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Documents
{
    public class PrescriptionSrcDb : SrcDbBase<Prescription>
    {
        const string sql = "SELECT KR.CII0350 AS Id, "
            + "KD.CII0750 AS DocumentId, "
            + "KR.KOC0350 AS NationalIdentificationNumber, " +
            "KR.TXC362000 As IdEPresrciption, " +
            "CP.KOC0440 As HIHIdWithoutRegion "
            + "FROM A00D0350 KR " +
            "JOIN P00D3200 PS ON (PS.ODI0350 = KR.ICI0000) " +
            "JOIN A00D0750 KD ON (KD.ICI0000 = PS.ODI0750) " +
            "LEFT JOIN A00C0440 CP ON (CP.ICI0000 = KR.ODI0440)";
        public PrescriptionSrcDb(ISourceConnectionProvider connectionProvider) : base(sql, connectionProvider)
        {
        }
    }
}
