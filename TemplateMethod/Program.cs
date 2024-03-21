using System.Diagnostics;
using TemplateMethod.Classes;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ЗАДАЧА:
            // создать единый шаблон обучающего мероприятия и его конкретные реализации - программу научной конференции и тренинга

            // ИМПЛЕМЕНТАЦИЯ TEMPLATE METHOD:
            // определён абстрактный класс Event, ему наследуют Conference и Training, которые переопределяют методы под свои задачи
            // порядок вызова методов определён только в Event

            var conference = new Conference("Artificial Intelligence and Natural Language");
            var training = new ProductTraining("Modular Equipment");

            conference.Run();
            Console.WriteLine();
            training.Run();
        }
    }
}
