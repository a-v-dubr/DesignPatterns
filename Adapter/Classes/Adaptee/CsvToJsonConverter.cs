using Newtonsoft.Json;

namespace Adapter.Classes.Adaptee
{
    internal class CsvToJsonConverter(string csv)
    {
        public string CsvString { get; } = csv;

        public string? ConvertToJson()
        {
            return JsonConvert.SerializeObject(CsvString, Formatting.Indented);
        }
    }
}
