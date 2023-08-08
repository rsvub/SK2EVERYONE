
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.Extensions.Configuration;
using System.Globalization;
using System.Text;

namespace SK2EVERYONE.DAL
{
    class CsvFile
    {
        public string FileName { get; set; }
    }
    public class CsvReaderProvider : ICsvReaderProvider, IDisposable
    {
        private readonly CsvReader csvReader;
        private readonly StreamReader reader;
        private readonly CsvFile settings;
        private string GetCsvFileName()
        {
            var csvPath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), "Csv");
            var csvFileName = Path.Combine(csvPath, settings.FileName);
            return csvFileName;
        }
        public CsvReaderProvider(IConfiguration configuration)
        {
            settings = configuration.GetSection(nameof(CsvFile)).Get<CsvFile>();
            reader = new StreamReader(GetCsvFileName());
            csvReader = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";", Encoding = Encoding.UTF8 });
        }
        public CsvReader Reader => csvReader;
        public void Dispose()
        {
            csvReader.Dispose();
        }
    }
}
