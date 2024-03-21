using Mediator.Classes.Domain;

namespace Mediator.Classes.MediatorClasses
{
    internal class Manager : IMediator
    {
        public Participant? Customer { get; private set; }
        public Participant? Developer { get; private set; }
        public Participant? Tester { get; private set; }

        public void SetCommand(Customer customer, Developer developer, Tester tester)
        {
            Customer = customer;
            Developer = developer;
            Tester = tester;
        }

        public void SendResult(Participant participant, string message)
        {
            if (participant is Customer)
            {
                Developer?.Notify(message);
            }

            else if (participant is Developer)
            {
                Tester?.Notify(message);
            }

            else if (participant is Tester)
            {
                Customer?.Notify(message);
            }
        }

        public void SendEdits(Participant participant, string message)
        {
            if (participant is Customer)
            {
                Developer?.Notify(message);
            }

            else if (participant is Developer)
            {
                Customer?.Notify(message);
            }

            else if (participant is Tester)
            {
                Developer?.Notify(message);
            }
        }
    }
}
