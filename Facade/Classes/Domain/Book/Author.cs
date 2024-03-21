namespace Facade.Classes.Domain.Book
{
    internal class Author
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; } = [];
    }
}
