using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.BLL
{
    public class UserImporter : Importer<User>
    {
        public UserImporter(ISrcDb<User> srcDb, IFirebirdDb<User> firebirdDb, ILogger<Importer<User>> logger) : base(srcDb, firebirdDb, logger)
        {
        }

        protected override string Group()
        {
            return $"Users";
        }

        protected override string ItemDetail(User item)
        {
            return $"Users";
        }

        protected override bool ValidateRecord(User item)
        {
            return true;
        }
    }
}
