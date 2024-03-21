using Decorator.Classes.Decorator;
using Decorator.Classes.Domain;

namespace Decorator.Classes
{
    internal abstract class DecoratorBase(IMessager messager) : IMessager
    {
        protected readonly IMessager _messager = messager;

        public Person Person => _messager.Person;

        public abstract void Send(string message);
    }
}
