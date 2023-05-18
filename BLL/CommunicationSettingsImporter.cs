using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.BLL
{
    public class CommunicationSettingsImporter : Importer<CommunicationSettings>
    {
        public CommunicationSettingsImporter(ISrcDb<CommunicationSettings> srcDb, IFirebirdDb<CommunicationSettings> firebirdDb, ILogger<Importer<CommunicationSettings>> logger) : base(srcDb, firebirdDb, logger)
        {
        }

        protected override string Group()
        {
            return $"CommunicationSettings";
        }

        protected override string ItemDetail(CommunicationSettings item)
        {
            return $"CommunicationSettings";
        }

        protected override bool ValidateRecord(CommunicationSettings item)
        {
            return true;
        }
    }
}
