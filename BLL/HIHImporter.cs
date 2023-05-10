using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.BLL
{
    public class HIHImporter : Importer<HIH>
    {
        public HIHImporter(ISrcDb<HIH> srcDb, IFirebirdDb<HIH> firebirdDb, ILogger<Importer<HIH>> logger) : base(srcDb, firebirdDb, logger)
        {
        }
    }
}
