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

        public void Import()
        {
            var imports = srcDb.GetAll();
            foreach (var import in imports)
            {
                //var info = $"RegionIdZP: {import.Id} Name: {import.Name} Region: {import.Region} IdZP: {import.IdWithoutRegion}";
                var info = $"Položka: {import}";
                if (string.IsNullOrEmpty($"{import}"))
                {
                    logger.LogWarning($"Chyba pri importu: {info}");
                    error = true;
                    continue;
                }
                logger.LogDebug(info);
                firebirdDb.Insert(import);
            };
            if (error)
            {
                logger.LogInformation($"Chyba pri importu - zkontrolujte log!");
            }
            else logger.LogInformation($"Import do Firebird OK!");
        }
    }
}
