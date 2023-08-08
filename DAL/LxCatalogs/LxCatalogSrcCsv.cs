using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.LxCatalogs
{
    public class LxCatalogSrcCsv : SrcCsvFile<LxCatalog>
    {
        public LxCatalogSrcCsv(ICsvReaderProvider csvReaderProvider) : base(csvReaderProvider)
        {
        }
    }
}
