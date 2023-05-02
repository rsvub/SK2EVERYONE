using FirebirdSql.Data.FirebirdClient;

namespace SK2EVERYONE.DAL
{
    public interface IFirebirdConnectionProvider
    {
        FbConnection Connection { get; }
    }
}
