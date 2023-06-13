using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.BLL
{
    public class PharmacyStockImporter : Importer<PharmacyStock>
    {
        public PharmacyStockImporter(ISrcDb<PharmacyStock> srcDb, IFirebirdDb<PharmacyStock> firebirdDb, ILogger<Importer<PharmacyStock>> logger) : base(srcDb, firebirdDb, logger)
        {
        }

        protected override string Group()
        {
            return $"PharmacyStock";
        }

        protected override string ItemDetail(PharmacyStock item)
        {
            return $"PharmacyStock";
        }

        protected override bool ValidateRecord(PharmacyStock item)
        {
            return true;
        }
    }
}
