namespace Flyweight.Classes
{
    internal class HeaderTemplate : IHeaderTemplate
    {
        public FlowLayoutPanel FlowLayoutPanel { get; } = CreateFlowLayoutPanel();

        public Font Font { get; }

        public string Text { get; }

        public HeaderTemplate(Font font, string text)
        {
            Font = font;
            Text = text;
            CreateTemplate();
        }

        public Control CreateTemplate()
        {
            var label = new Label
            {
                Anchor = AnchorStyles.Top,
                AutoSize = true,
                Font = Font,
                Text = Text
            };

            FlowLayoutPanel.Controls.Add(label);
            return label;
        }

        public static FlowLayoutPanel CreateFlowLayoutPanel()
        {
            return new FlowLayoutPanel()
            {
                Anchor = AnchorStyles.Top,
                FlowDirection = FlowDirection.TopDown,
                Padding = new Padding(5),
                Size = new Size(212, 210),
                Dock = DockStyle.Fill,
            };
        }
    }
}
