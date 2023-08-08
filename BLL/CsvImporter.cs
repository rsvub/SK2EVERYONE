using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;

namespace SK2EVERYONE.BLL
{
    public interface ICsvImporter<TModel> where TModel : class
    {
        void CsvImport();
    }
    public abstract class CsvImporter<TModel> : ICsvImporter<TModel> where TModel : class
    {
        private readonly ISrcCsv<TModel> srcCsv;
        private readonly IFirebirdDb<TModel> firebirdDb;
        private readonly ILogger<CsvImporter<TModel>> logger;
        protected abstract string Group();
        protected abstract string ItemDetail(TModel record);

        public CsvImporter(ISrcCsv<TModel> srcCsv, IFirebirdDb<TModel> firebirdDb, ILogger<CsvImporter<TModel>> logger)
        {
            this.srcCsv = srcCsv;
            this.firebirdDb = firebirdDb;
            this.logger = logger;
        }

        public void CsvImport()
        {
            logger.LogInformation($"Csv Import {Group()} starting!");
            var records = srcCsv.GetAll();
            foreach ( var record in records )
            {
                logger.LogDebug(ItemDetail(record));
                firebirdDb.Insert(record);
            }
            logger.LogInformation($"Csv Import {Group()} finished OK!");
        }
    }
}
