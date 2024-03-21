using Mediator.Classes.MediatorClasses;

namespace Mediator.Classes.Domain
{
    internal class Tester(IMediator mediator) : Participant(mediator)
    {
        public override void Notify(string message)
        {
            Console.WriteLine($"Message for tester: {message}");
        }
    }
}
