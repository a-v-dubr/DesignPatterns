using Prototype.PrototypeClasses;

namespace Prototype.Domain
{
    internal class Company(string name) : IPrototype
    {
        public string Name { get; } = name;

        public List<Person> Employees { get; set; } = [];

        public IPrototype DeepClone()
        {
            var clonedCompany = new Company(Name);
            foreach (var e in Employees)
            {
                var clonedEmployee = new Person(e.Id, e.Name, e.Age, clonedCompany);
                clonedCompany.Employees.Add(clonedEmployee);
            }
            return clonedCompany;
        }

        public IPrototype ShallowClone()
        {
            var cloned = new Company(Name) { Employees = Employees };
            return cloned;
        }
    }
}
