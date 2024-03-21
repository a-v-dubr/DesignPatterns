namespace Flyweight.Classes
{
    internal class Document(IHeaderTemplate labelTemplate, string content)
    {
        public IHeaderTemplate HeaderTemplate { get; } = labelTemplate;
        public string Content { get; } = content;

        public void Render(Form form)
        {
            HeaderTemplate.FlowLayoutPanel.Controls.Add(GetContentsAsRichTextBox());
            form.Controls.Add(HeaderTemplate.FlowLayoutPanel);
        }

        private RichTextBox GetContentsAsRichTextBox()
        {
            return new RichTextBox()
            {
                Text = Content,
                ReadOnly = true,
                WordWrap = true,
                AutoSize = true,
                BorderStyle = BorderStyle.None
            };
        }
    }
}
