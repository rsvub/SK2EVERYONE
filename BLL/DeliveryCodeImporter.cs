using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.BLL
{
    public class DeliveryCodeImporter : Importer<DeliveryCode>
    {
        public DeliveryCodeImporter(ISrcDb<DeliveryCode> srcDb, IFirebirdDb<DeliveryCode> firebirdDb, ILogger<Importer<DeliveryCode>> logger) : base(srcDb, firebirdDb, logger)
        {
        }

        protected override string Group()
        {
            return "DeliveryCodes";
        }

        protected override string ItemDetail(DeliveryCode item)
        {
            return "DeliveryCodes";
        }

        protected override bool ValidateRecord(DeliveryCode item)
        {
            return true;
        }
    }
}
