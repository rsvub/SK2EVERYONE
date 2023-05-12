using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.LoyaltyCards
{
    public class LoyaltyCardSrcDb : SrcDbBase<LoyaltyCard>
    {
        const string sql = "SELECT CASE WHEN ISNULL(T1.TXC802005,'') = '' THEN '@' ELSE TXC802005 END AS TXC802005, " +
            "T1.CIC802000 AS CardNumber, " +
            "T1.CIC8020 AS CardBarCode, " +
            "T1.ODI8021 AS CardType, " +
            "T1.ZNB8020 AS Active, " +
            "T1.HON802000 AS OtcPoint, " +
            "T1.HON802009 AS RxPoint, " +
            "T1.ZNC8020 AS Sex, " +
            "T1.TXC802001 AS Surname, " +
            "T1.TXC802021 AS Name, " +
            "T1.TXC802002 AS Street, " +
            "T1.TXC802003 AS City, " +
            "T1.TXC802004 AS ZipCode, " +
            "T1.TXC802005 AS Email, " +
            "T1.TXC802006 AS Phone, " +
            "T1.TXC802008 AS Education, " +
            "T1.TXC802009 AS Industry, " +
            "T1.TXC802010 AS Employment, " +
            "T1.TXC802015 AS Title, " +
            "T1.TXC802020 AS Note, " +
            "T1.DAD802002 AS DateOfBirth, " +
            "T1.ODI1001 AS UnitId, " +
            "T1.ODI2703 AS PhysicianId" +
            " FROM A00D8020 T1";
        public LoyaltyCardSrcDb(ISourceConnectionProvider connectionProvider) : base(sql, connectionProvider)
        {
        }
    }
}
