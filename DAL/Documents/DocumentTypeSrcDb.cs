using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Documents
{
    public class DocumentTypeSrcDb : SrcDbBase<DocumentType>
    {
        const string sql = "SELECT ICI0000 AS Id, "
            + "NAC0741 AS Name, "
            + "KOC0741 AS Type "
            + "FROM A00S0741";
        public DocumentTypeSrcDb(ISourceConnectionProvider connectionProvider) : base(sql, connectionProvider)
        {
        }
    }
}
