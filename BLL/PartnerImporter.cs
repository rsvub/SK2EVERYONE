using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.BLL
{
    public class PartnerImporter : Importer<Partner>
    {
        public PartnerImporter(ISrcDb<Partner> srcDb, IFirebirdDb<Partner> firebirdDb, ILogger<Importer<Partner>> logger) : base(srcDb, firebirdDb, logger)
        {
        }

        protected override string Group()
        {
            return $"Partners";
        }

        protected override string ItemDetail(Partner item)
        {
            return $"Partners";
        }

        protected override bool ValidateRecord(Partner item)
        {
            return true;
        }
    }
}
