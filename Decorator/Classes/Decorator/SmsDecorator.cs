using Decorator.Classes.Decorator;
using Decorator.Classes.Domain;

namespace Decorator.Classes
{
    internal class SmsDecorator(IMessager messager) : DecoratorBase(messager: messager)
    {
        public override void Send(string message)
        {
            SendSmsMessage(message);
            _messager.Send(message);
        }

        private void SendSmsMessage(string message)
        {
            Console.WriteLine($"Sms '{message}' sent to {Person.Phone}");
        }
    }
}
