using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Documents
{
    public class DocumentTypeFirebirdDb : FirebirdDbBase<DocumentType>
    {
        const string sql = "insert into documenttype(id, name, type) " +
            "values (@id, @name, @type)";
        public DocumentTypeFirebirdDb(IFirebirdConnectionProvider connectionProvider) : base(sql, connectionProvider)
        {
        }

    }
}
