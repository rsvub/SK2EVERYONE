using System.Data.SqlClient;

namespace SK2EVERYONE.DAL
{
    public interface ISourceConnectionProvider
    {
        SqlConnection Connection { get; }
    }
}