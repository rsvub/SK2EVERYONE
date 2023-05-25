using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.BLL
{
    public class ProductImporter : Importer<Product>
    {
        public ProductImporter(ISrcDb<Product> srcDb, IFirebirdDb<Product> firebirdDb, ILogger<Importer<Product>> logger) : base(srcDb, firebirdDb, logger)
        {
        }

        protected override string Group()
        {
            return $"Products";
        }

        protected override string ItemDetail(Product item)
        {
            return $"Products";
        }

        protected override bool ValidateRecord(Product item)
        {
            return true;
        }
    }
}
