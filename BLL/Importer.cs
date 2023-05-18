using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;

namespace SK2EVERYONE.BLL
{
    public interface IImporter<Tmodel> where Tmodel : class
    {
        void Import();
    }
    public abstract class Importer<Tmodel> : IImporter<Tmodel> where Tmodel : class
    {
        private readonly ISrcDb<Tmodel> srcDb;
        private readonly IFirebirdDb<Tmodel> firebirdDb;
        private readonly ILogger<Importer<Tmodel>> logger;
        private bool error = false;
        
        public Importer(ISrcDb<Tmodel> srcDb, IFirebirdDb<Tmodel> firebirdDb, ILogger<Importer<Tmodel>> logger)
        {
            this.srcDb = srcDb;
            this.firebirdDb = firebirdDb;
            this.logger = logger;
        }

        protected abstract bool ValidateRecord(Tmodel item);
        protected abstract string ItemDetail(Tmodel item);
        protected abstract string Group();

        public void Import()
        {
            logger.LogInformation($"Import {Group()} starting!");
            var imports = srcDb.GetAll();
            foreach (var import in imports)
            {
                if (!ValidateRecord(import))
                {
                    logger.LogWarning($"Import error on item: {ItemDetail(import)}");
                    error = true;
                    continue;
                }
                logger.LogDebug(ItemDetail(import));
                firebirdDb.Insert(import);
            };
            if (error)
            {
                logger.LogInformation($"Import {Group()} error - check log!");
            }
            else logger.LogInformation($"Import {Group()} to Firebird finished OK!");
        }
    }
}
