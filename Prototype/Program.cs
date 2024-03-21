using Prototype.Domain;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ЗАДАЧА:
            // создавать копии объектов разными способами (с полным или частичным копированием полей)

            // ИМПЛЕМЕНТАЦИЯ PROTOTYPE:
            // копии создаются внутри классов-прототипов, и соотв. методы копирования имеют доступ ко всем полям
            // класс может иметь несколько вариантов копирования для разных целей, детали копирования скрыты от клиентского кода

            var company = new Company("Microsoft");
            var employee = new Person(1, "John", 25, company);
            company.Employees.Add(employee);

            var companyDeepClone = company.DeepClone();
            
            Console.WriteLine($"Company's Employees hash code {company.Employees.GetHashCode()}\n" +
                $"Company clone's Employees hash code {(companyDeepClone as Company)?.Employees.GetHashCode()}");           
        }
    }
}
