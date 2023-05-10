using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.BLL
{
    public class PatientImporter : Importer<Patient>
    {
        
        public PatientImporter(ISrcDb<Patient> srcDb, IFirebirdDb<Patient> firebirdDb, ILogger<Importer<Patient>> logger) : base(srcDb, firebirdDb, logger)
        {
        }
    }
}
