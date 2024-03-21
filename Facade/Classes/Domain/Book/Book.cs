namespace Facade.Classes.Domain.Book
{
    internal class Book
    {
        public string Title { get; set; }

        public Author Author { get; set; }
        public List<string> Contents { get; set; } = [];
    }
}
