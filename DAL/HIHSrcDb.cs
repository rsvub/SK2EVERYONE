using Microsoft.Extensions.Configuration;
using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL
{
    public class HIHSrcDb : SrcDbBase<HIH>
    {
        const string sql = "SELECT T.KOC0441 AS Id, T.NAC044101 As Name, T.NAC044102 As Region, T3.KOC0440 As IdWithoutRegion FROM A00C0441 T LEFT JOIN A00C0440 T3 ON(T3.ICI0000 = T.ODI0440)";
        public HIHSrcDb(ISourceConnectionProvider connectionProvider) :base(sql, connectionProvider)
        {
        }
    }
}

