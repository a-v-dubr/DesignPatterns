using Facade.Classes.Domain.Book;
using Facade.Classes.Domain.CPU;
using Facade.Classes.Infrastructure.Repository;

namespace Facade.Classes.FacadeClasses
{
    internal class EBookFacade
    {
        private readonly CPU _cpu;
        private readonly Memory _memory;
        private readonly BookRepository _bookRepository;
        private List<Book> _books = [];

        public EBookFacade()
        {
            _cpu = new CPU();
            _memory = new Memory();
            _bookRepository = new BookRepository();
        }

        public void Start()
        {
            TurnOnCPU();
            DisplayWelcomeMessage();
            UploadBooks();
        }

        private void TurnOnCPU()
        {
            _cpu.Freeze();
            _memory.Load();
            _cpu.Execute();
        }

        private static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome!");
        }

        private void UploadBooks()
        {
            _books = _bookRepository.Read();
            Console.WriteLine($"Books available: {_books.Count}");
        }
    }
}
