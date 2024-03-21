using Decorator.Classes.Domain;

namespace Decorator.Classes.Decorator
{
    internal interface IMessager
    {
        Person Person { get; }
        void Send(string message);
    }
}
