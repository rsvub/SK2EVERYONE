using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Partners
{
    public class CommunicationSettingsSrcDB : SrcDbBase<CommunicationSettings>
    {
        const string sql = "SELECT ICI0000 AS Id, " +
            "KOC1215 AS Code, " +
            "defWSDL AS DefWSDL, " +
            "defURL AS DefURL, " +
            "defSvc AS DefSvc, " +
            "defPrt AS DefPrt, " +
            "CII222200 AS TimeToAnswer, " +
            "CII222201 AS CycleTime, " +
            "CII222202 AS MaxRow, " +
            "TXC2222 AS Description, " +
            "TXC222200 AS Address, " +
            "TXC222210 AS B2BAddress " +
            "FROM A00C2222 " +
            "WHERE ICI0000 > 0";
        public CommunicationSettingsSrcDB(ISourceConnectionProvider connectionProvider) : base(sql, connectionProvider)
        {
        }
    }
}
