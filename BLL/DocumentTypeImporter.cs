using Microsoft.Extensions.Logging;
using SK2EVERYONE.DAL;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.BLL
{
    public class DocumentTypeImporter : Importer<DocumentType>
    {
        public DocumentTypeImporter(ISrcDb<DocumentType> srcDb, IFirebirdDb<DocumentType> firebirdDb, ILogger<Importer<DocumentType>> logger) : base(srcDb, firebirdDb, logger)
        {
        }

        protected override string Group()
        {
            return $"DocumentTypes";
        }

        protected override string ItemDetail(DocumentType item)
        {
            return $"DocumentTypes";
        }

        protected override bool ValidateRecord(DocumentType item)
        {
            return true;
        }
    }
}
