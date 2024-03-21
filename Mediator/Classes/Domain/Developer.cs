using Mediator.Classes.MediatorClasses;

namespace Mediator.Classes.Domain
{
    internal class Developer(IMediator mediator) : Participant(mediator)
    {
        public override void Notify(string message)
        {
            Console.WriteLine($"Message for developer: {message}");
        }
    }
}
