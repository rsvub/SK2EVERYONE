using CsvHelper;

namespace SK2EVERYONE.DAL
{
    public interface ICsvReaderProvider
    {
        CsvReader Reader { get; }
    }
}
