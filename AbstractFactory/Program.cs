using AbstractFactory.Classes.Factories;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ЗАДАЧА:
            // создавать объекты Car типов Sedan и Coupe таким образом, чтобы серия созданных объектов относилась к одному бренду (Ford / Toyota)

            // ИМПЛЕМЕНТАЦИЯ ABSTRACT FACTORY:
            // АФ ICarFactory объединяет конкретные фабрики, возвращающие объекты базовых типов Sedan и Coupe с определённым в конкр. фабрике
            // признаком (Ford / Toyota); тип конкретной фабрики определяет клиент, и далее гарантированно получаем объекты с нужным признаком
            // без необходимости явно указывать типы получаемых объектов

            var factory = new FordFactory();
            Console.WriteLine($"{factory.CreateCoupe()} is created");
            Console.WriteLine($"{factory.CreateSedan()} is created");
        }
    }
}
