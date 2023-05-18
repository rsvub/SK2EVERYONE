using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.BLL
{
    public class LoyaltyCardImporter : Importer<LoyaltyCard>
    {
        public LoyaltyCardImporter(ISrcDb<LoyaltyCard> srcDb, IFirebirdDb<LoyaltyCard> firebirdDb, ILogger<Importer<LoyaltyCard>> logger) : base(srcDb, firebirdDb, logger)
        {
        }

        protected override string Group()
        {
            return $"LoyaltyCards";
        }

        protected override string ItemDetail(LoyaltyCard item)
        {
            return $"CardNumber: {item.CardNumber} CardBarCode: {item.CardBarCode} Active: {item.Active} Surname: {item.Surname} Name: {item.Name} Street: {item.Street} City: {item.City} ZipCode: {item.ZipCode} Phone: {item.Phone}";
        }

        protected override bool ValidateRecord(LoyaltyCard item)
        {
            return !string.IsNullOrEmpty(item.CardNumber);
        }
    }
}
