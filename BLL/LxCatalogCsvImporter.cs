using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.BLL
{
    public class LxCatalogCsvImporter : CsvImporter<LxCatalog>
    {
        public LxCatalogCsvImporter(ISrcCsv<LxCatalog> srcCsv, IFirebirdDb<LxCatalog> firebirdDb, ILogger<CsvImporter<LxCatalog>> logger) : base(srcCsv, firebirdDb, logger)
        {
        }

        protected override string Group()
        {
            return $"LxCatalog";
        }

        protected override string ItemDetail(LxCatalog record)
        {
            return $"Id: {record.Id} Name: {record.Name} L1Code: {record.L1Code} L1Name: {record.L1Name}";
        }
    }
}
