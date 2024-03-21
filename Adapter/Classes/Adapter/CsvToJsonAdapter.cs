using Adapter.Classes.Adaptee;

namespace Adapter.Classes.Adapter
{
    internal class CsvToJsonAdapter(CsvToJsonConverter csvConverter) : IDataAdapter
    {
        private readonly CsvToJsonConverter _csvConverter = csvConverter;

        public string? Convert()
        {
            return _csvConverter.ConvertToJson();
        }
    }
}
