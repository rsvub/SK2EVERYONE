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
        private readonly IHIHFirebirdDb hIHFirebirdDb;
        private readonly ILogger<HIHImporter> logger;

        public HIHImporter(ISrcDb<HIH> hIHSrcDb, IHIHFirebirdDb hIHFirebirdDb, ILogger<HIHImporter> logger)
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
                if (hih.Id != "")
                {
                    logger.LogWarning(info);
                    continue;
                }
                logger.LogInformation(info);
                hIHFirebirdDb.InsertHIH(hih);
            };
            logger.LogInformation("Import HIH to Firebird OK!");
        }
    }
}
