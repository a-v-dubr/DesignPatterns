namespace Observer.Classes
{
    internal class Article(string title, string content)
    {
        public string Title { get; } = title;

        public string Content { get; } = content;
    }
}
