using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.BLL
{
    public class ProductCodeImporter : Importer<ProductCode>
    {
        public ProductCodeImporter(ISrcDb<ProductCode> srcDb, IFirebirdDb<ProductCode> firebirdDb, ILogger<Importer<ProductCode>> logger) : base(srcDb, firebirdDb, logger)
        {
        }

        protected override string Group()
        {
            return $"ProductCodes";
        }

        protected override string ItemDetail(ProductCode item)
        {
            return $"ProductCodes";
        }

        protected override bool ValidateRecord(ProductCode item)
        {
            return true;
        }
    }
}
