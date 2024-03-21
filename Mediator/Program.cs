using Mediator.Classes.Domain;
using Mediator.Classes.MediatorClasses;

namespace Mediator
{
    internal class Program
    {
        // ЗАДАЧА:
        // организовать взаимодействие объектов Клиента, Разработчика и Тестировщика таким образом, чтобы в процессе разработки приложения 
        // они обменивались сообщениями, не обращаясь друг к другу напрямую

        // ИМПЛЕМЕНТАЦИЯ MEDIATOR:
        // интерфейс IMediator содержит методы отправки результата или правок, его реализует конретный mediator - Manager, который также 
        // определяет, кому будут направлены вызовы методов в зависимости от типа вызывающих объектов
        // абстрактный класс Participant определяет для доменных классов объект-mediator и методы получения и отправки сообщений 

        static void Main(string[] args)
        {
            var mediator = new Manager();
            var customer = new Customer(mediator);
            var developer = new Developer(mediator);
            var tester = new Tester(mediator);

            mediator.SetCommand(customer, developer, tester);

            customer.SendResult("sending specification");
            developer.SendEdits("more details of specification required");
            customer.SendResult("sending detailed specification");
            developer.SendResult("application is ready for testing");
            tester.SendEdits("edits required");
            developer.SendResult("edits made");
            tester.SendResult("application is ready for release");
        }
    }
}
