using Adapter.Classes.Adaptee;
using Adapter.Classes.Adapter;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ЗАДАЧА:
            // используется API, которое работает с данными в формате xml, в то время как наше приложение использует только json
            // необходим функционал преобразования json в xml

            // АЛЬТЕРНАТИВА ПАТТЕРНУ
            // можно напрямую вызывать метод конвертации у объекта json, и если способ конвертации единственный, это может быть 
            // валидным решением; однако, если используется больше вариантов конвертации (например, csv в json, bson в json и
            // т.д.), вызов каждый раз конкретного метода классов будет неудобным

            // ИМПЛЕМЕНТАЦИЯ ADAPTER:
            // адаптируемые классы - CsvConverter и JsonConverter, интерфейс IDataAdapter определяет метод конвертации
            // снаружи определяется тип данных, с которым будем работать (json, csv), а также нужный тип адаптера
            // для клиента метод Convert() инкапсулирует логику конвертации независимо от того, какие форматы используются

            string jsonString = "{\"Name\": \"John Doe\", \"Age\": 25, \"Email\": \"johndoe@mail.com\"}";
            var jsonConverter = new Classes.Adaptee.JsonToXmlConverter(jsonString);
            var adapter1 = new JsonToXmlAdapter(jsonConverter);

            string csvString = @"Name,Age,Email
                                John Doe,25,johndoe@mail.com
                                Jane Doe,30,janedoe@mail.com";
            var csvConverter = new CsvToJsonConverter(csvString);
            var adapter2 = new CsvToJsonAdapter(csvConverter);

            Console.WriteLine($"{adapter1.Convert()}\n\n{adapter2.Convert()}");
        }
    }
}
