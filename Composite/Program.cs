using Composite.Classes;
using Composite.Data;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ЗАДАЧА:
            // реализовать поиск по товарному каталогу, который будет возвращать названия как товаров, так и категорий 

            // ИМПЛЕМЕНТАЦИЯ COMPOSITE:
            // классы товара и категории реализуют ISearch и определённый в нём метод Search. объекты-"ветки" 
            // внутри метода Search вызывают этот метод также у своих дочерних объектов ISearch, "листья" -
            // только у себя и на них последовательный вызов Search завершается

            var catalogue = CatalogueContents.GetCatalogue();
            var searchResults = new List<ISearch>();

            catalogue.Search(Console.ReadLine()!, searchResults);

            foreach (var r in searchResults)
            {
                Console.WriteLine(r.ToString());
            }
        }
    }
}
