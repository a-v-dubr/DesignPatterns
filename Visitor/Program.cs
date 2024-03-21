using Visitor.Classes.Domain;
using Visitor.Classes.VisitorClasses;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ЗАДАЧА:
            // реализовать возможность сериализации объектов Person и Company, не добавляя соотв. методы в код этих классов

            // ИМПЛЕМЕНТАЦИЯ VISITOR:
            // поддерживается типобезопасность, везде прямо указан используемый тип
            // определён интерфейс с методом принятия visitor'а, этот интерфейс реализуют доменные классы, вызывая в методе 
            // Accept вызов IVisitor на своём текущем объекте; в классах IVisitor определены методы посещения каждого доменного класса

            var serializerManager = new SerializerManager();
            serializerManager.Add(new Person(1, "John Doe", "doe@mail.com", DateTime.Now));
            serializerManager.Add(new Company(1, "Microsoft", "123321abc", DateTime.Now));

            serializerManager.Accept(new JsonVisitor());
            serializerManager.Accept(new XmlVisitor());
        }
    }
}
