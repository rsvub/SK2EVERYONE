using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.BLL
{
    public class DegressiveMarginImporter : Importer<DegressiveMargin>
    {
        public DegressiveMarginImporter(ISrcDb<DegressiveMargin> srcDb, IFirebirdDb<DegressiveMargin> firebirdDb, ILogger<Importer<DegressiveMargin>> logger) : base(srcDb, firebirdDb, logger)
        {
        }

        protected override string Group()
        {
            return $"DegressiveMargins";
        }

        protected override string ItemDetail(DegressiveMargin item)
        {
            return $"DegressiveMargins";
        }

        protected override bool ValidateRecord(DegressiveMargin item)
        {
            return true;
        }
    }
}
