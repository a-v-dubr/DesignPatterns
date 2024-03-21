namespace Flyweight.Classes
{
    internal class HeaderTemplatesFactory
    {
        private readonly Dictionary<string, IHeaderTemplate> _samples = [];

        public IHeaderTemplate GetTemplateLabel(Font font, string content)
        {
            if (!_samples.TryGetValue(content, out IHeaderTemplate? value))
            {
                value = new HeaderTemplate(font, content);
                _samples[content] = value;
            }
            return value;
        }
    }
}
