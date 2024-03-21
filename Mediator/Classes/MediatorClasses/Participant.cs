namespace Mediator.Classes.MediatorClasses
{
    internal abstract class Participant(IMediator mediator)
    {
        protected IMediator _mediator = mediator;

        public virtual void SendResult(string message)
        {
            _mediator.SendResult(this, message);
        }

        public virtual void SendEdits(string message)
        {
            _mediator.SendEdits(this, message);
        }

        public abstract void Notify(string message);
    }
}
