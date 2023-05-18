using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.BLL
{
    public class HIHImporter : Importer<HIH>
    {
        public HIHImporter(ISrcDb<HIH> srcDb, IFirebirdDb<HIH> firebirdDb, ILogger<Importer<HIH>> logger) : base(srcDb, firebirdDb, logger)
        {
        }

        protected override string Group()
        {
            return $"HIHs";
        }

        protected override string ItemDetail(HIH item)
        {
            return $"RegionIdZP: {item.Id} Name: {item.Name} Region: {item.Region} IdZP: {item.IdWithoutRegion}";
        }

        protected override bool ValidateRecord(HIH item)
        {
            return !string.IsNullOrEmpty(item.Id);
        }
    }
}
