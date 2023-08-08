using CsvHelper;

namespace SK2EVERYONE.DAL
{
    public interface ISrcCsv<TModel> where TModel : class
    {
        IEnumerable<TModel> GetAll();
    }
    public abstract class SrcCsvFile<TModel> : ISrcCsv<TModel> where TModel : class
    {
        private readonly CsvReader csvReader;
        protected SrcCsvFile(ICsvReaderProvider csvReaderProvider)
        {
            csvReader = csvReaderProvider.Reader;
        }
        public IEnumerable<TModel> GetAll()
        {
            return csvReader.GetRecords<TModel>();
        }
    }
}
