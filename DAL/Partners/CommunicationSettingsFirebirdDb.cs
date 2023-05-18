using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Partners
{
    public class CommunicationSettingsFirebirdDb : FirebirdDbBase<CommunicationSettings>
    {
        const string sql = "insert into communicationsettings(Id, Code, DefWSDL, DefURL, DefSvc, DefPrt, TimeToAnswer, CycleTime, MaxRow, Description, Address, B2BAddress) " +
            "values (@Id, @Code, @DefWSDL, @DefURL, @DefSvc, @DefPrt, @TimeToAnswer, @CycleTime, @MaxRow, @Description, @Address, @B2BAddress)";
        public CommunicationSettingsFirebirdDb(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
