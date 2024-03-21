namespace Decorator.Classes.Decorator
{
    internal class MobilePushDecorator(IMessager messager) : DecoratorBase(messager: messager)
    {
        public override void Send(string message)
        {
            SendPushMessage(message);
            _messager.Send(message);
        }

        private void SendPushMessage(string message)
        {
            Console.WriteLine($"Message '{message}' sent to {Person.Name} by mobile push");
        }
    }
}
