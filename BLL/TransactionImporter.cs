using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.BLL
{
    public class TransactionImporter : Importer<Transaction>
    {
        public TransactionImporter(ISrcDb<Transaction> srcDb, IFirebirdDb<Transaction> firebirdDb, ILogger<Importer<Transaction>> logger) : base(srcDb, firebirdDb, logger)
        {
        }

        protected override string Group()
        {
            return $"Transaction";
        }

        protected override string ItemDetail(Transaction item)
        {
            return $"Transaction";
        }

        protected override bool ValidateRecord(Transaction item)
        {
            return true;
        }
    }
}
