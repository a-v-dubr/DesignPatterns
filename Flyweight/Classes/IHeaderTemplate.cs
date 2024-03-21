namespace Flyweight.Classes
{
    internal interface IHeaderTemplate
    {
        Font Font { get; }
        string Text { get; }
        FlowLayoutPanel FlowLayoutPanel { get; }
        Control CreateTemplate();
    }
}
