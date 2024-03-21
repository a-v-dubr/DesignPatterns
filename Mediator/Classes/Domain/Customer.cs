using Mediator.Classes.MediatorClasses;

namespace Mediator.Classes.Domain
{
    internal class Customer(IMediator mediator) : Participant(mediator)
    {
        public override void Notify(string message)
        {
            Console.WriteLine($"Message for customer: {message}");
        }
    }
}
