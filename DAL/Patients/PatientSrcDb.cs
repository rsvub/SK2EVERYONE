using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Patients
{
    public class PatientSrcDb : SrcDbBase<Patient>
    {
        const string sql = "SELECT T1.NAC271200 AS Name, " +
            "T1.KOC0350 AS NationalIdentificationNumber, " +
            "T3.KOC0441 AS HIHId, " +
            "T1.NAC271202 AS Street, " +
            "T1.NAC271201 AS City, " +
            "T1.NAC271203 AS ZipCode, " +
            "T1.CIC271200 AS PhoneNumber, " +
            "T1.CIC271201 AS MobileNumber " +
            "FROM P00C2712 T1 " +
            "LEFT JOIN A00C0441 T3 ON (T3.ICI0000 = T1.ODI0441) ";
        public PatientSrcDb(ISourceConnectionProvider connectionProvider) : base(sql, connectionProvider)
        {
        }
    }
}
