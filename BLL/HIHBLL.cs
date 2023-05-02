using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.BLL
{
    public interface IHIHImporter
    {
        void Import();
    }
    public class HIHImporter : IHIHImporter
    {
        private readonly ISrcDb<HIH> hIHSrcDb;
        private readonly IFirebirdDb hIHFirebirdDb;
        private readonly ILogger<HIHImporter> logger;

        public HIHImporter(ISrcDb<HIH> hIHSrcDb, IFirebirdDb hIHFirebirdDb, ILogger<HIHImporter> logger)
        {
            this.hIHSrcDb = hIHSrcDb;
            this.hIHFirebirdDb = hIHFirebirdDb;
            this.logger = logger;
        }

        public void Import()
        {
            var hihs = hIHSrcDb.GetAll();
            foreach (var hih in hihs)
            {
                var info = $"RegionIdZP: {hih.Id} Name: {hih.Name} Region: {hih.Region} IdZP: {hih.IdWithoutRegion}";
                if (string.IsNullOrEmpty(hih.Id))
                {
                    logger.LogWarning(info);
                    continue;
                }
                logger.LogDebug(info);
                object obj = new { id = hih.Id, name = hih.Name, region = hih.Region, idwithoutregion = hih.IdWithoutRegion };
                hIHFirebirdDb.Insert(obj);
            };
            logger.LogInformation("Import HIH to Firebird OK!");
        }
    }
}
