using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL.HIHs;

namespace SK2EVERYONE.BLL.HIHs
{
    public interface IHIHImporter
    {
        void Import();
    }
    public class HIHImporter : IHIHImporter
    {
        private readonly IHIHSrcDb hIHSrcDb;
        private readonly IHIHFirebirdDb hIHFirebirdDb;
        private readonly ILogger<HIHImporter> logger;

        public HIHImporter(IHIHSrcDb hIHSrcDb, IHIHFirebirdDb hIHFirebirdDb, ILogger<HIHImporter> logger)
        {
            this.hIHSrcDb = hIHSrcDb;
            this.hIHFirebirdDb = hIHFirebirdDb;
            this.logger = logger;
        }

        public void Import()
        {
            var hihs = hIHSrcDb.GetAllHIH();
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
#if false
    public class HIHBLL
    {
        public List<HIH> GetAllHIH()
        {
            List<HIH> hihList =  new HIHSrcDb().GetAllHIH();
            List<HIH> checkHIHList = new List<HIH>();

            foreach (HIH h in hihList)
            {
                if (h.Id != "")
                {
                    checkHIHList.Add(new HIH
                    {
                        Id = h.Id,
                        Name = h.Name,
                        Region = h.Region,
                        IdWithoutRegion = h.IdWithoutRegion,
                    });
                }
            }
            return checkHIHList;
        }
    }
#endif
}
