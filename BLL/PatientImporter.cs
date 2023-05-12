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

        protected override string ItemDetail(Patient item)
        {
            return $"Name: {item.Name} BirtNumber: {item.BirthNumber} HIHId: {item.HIHId} Street: {item.Street} City: {item.City} ZipCode: {item.ZipCode} PhoneNumber: {item.PhoneNumber} MobileNumber: {item.MobileNumber}";
        }

        protected override bool ValidateRecord(Patient item)
        {
            return !string.IsNullOrEmpty(item.BirthNumber);
        }
    }
}
