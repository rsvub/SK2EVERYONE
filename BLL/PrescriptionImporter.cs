using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.BLL
{
    public class PrescriptionImporter : Importer<Prescription>
    {
        public PrescriptionImporter(ISrcDb<Prescription> srcDb, IFirebirdDb<Prescription> firebirdDb, ILogger<Importer<Prescription>> logger) : base(srcDb, firebirdDb, logger)
        {
        }

        protected override string Group()
        {
            return $"Prescriptions";
        }

        protected override string ItemDetail(Prescription item)
        {
            return $"Prescriptions";
        }

        protected override bool ValidateRecord(Prescription item)
        {
            return true;
        }
    }
}
