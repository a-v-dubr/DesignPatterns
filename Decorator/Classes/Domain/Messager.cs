using Decorator.Classes.Decorator;

namespace Decorator.Classes.Domain
{
    internal class Messager(Person person) : IMessager
    {
        public Person Person => person;

        public void Send(string message)
        {
            Console.WriteLine($"Message '{message}' sent to email {Person.Email}");
        }
    }
}
