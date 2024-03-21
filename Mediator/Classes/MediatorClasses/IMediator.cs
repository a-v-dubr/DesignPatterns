namespace Mediator.Classes.MediatorClasses
{
    internal interface IMediator
    {
        void SendEdits(Participant participant, string message);

        void SendResult(Participant participant, string message);
    }
}
