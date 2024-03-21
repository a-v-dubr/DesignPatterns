using Decorator.Classes;
using Decorator.Classes.Decorator;
using Decorator.Classes.Domain;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ЗАДАЧА:
            // существует класс-мессенджер, отправляющий емейл-рассылки с заданным текстом     
            // необходимо реализовать дополнительные виды рассылок (смс, веб-пуши, мобильные пуши и пр.)

            // ИМПЛЕМЕНТАЦИЯ DECORATOR:
            // классы с дополнительной функциональностью реализуют тот же интерфейс, что и исходные классы
            // конкретный тип декоратора определяет клиент
            // !! ВАЖНО: декоратор обязательно реализует и новое (своё), и базовое поведение обёрнутого объекта
            // при последовательном использовании декораторов функционал будет суммироваться

            var person = new Person("John Doe", "doe@mail.com", 123321123);
            IMessager messager = new Messager(person);
            messager = new SmsDecorator(messager); // будут вызваны отправка смс и отправка емейл
            messager.Send("Hello");

            messager = new MobilePushDecorator(messager); // отправка моб. пуша + смс + емейл
            messager.Send("Hello again");
        }
    }
}
