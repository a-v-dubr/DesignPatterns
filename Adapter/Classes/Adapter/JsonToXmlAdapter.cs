namespace Adapter.Classes.Adapter
{
    internal class JsonToXmlAdapter(Adaptee.JsonToXmlConverter jsonConverter) : IDataAdapter
    {
        private readonly Adaptee.JsonToXmlConverter _jsonConverter = jsonConverter;

        public string? Convert()
        {
            return _jsonConverter.ConvertToXml();
        }
    }
}
