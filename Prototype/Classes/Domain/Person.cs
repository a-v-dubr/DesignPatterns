using Prototype.PrototypeClasses;

namespace Prototype.Domain
{
    internal class Person(int id, string name, int age, Company company) : IPrototype
    {
        public int Id { get; } = id;
        public string Name { get; } = name;
        public int Age { get; } = age;
        public Company Company { get; } = company;

        public IPrototype ShallowClone()
        {
            return new Person(Id, Name, Age, Company);
        }

        public IPrototype DeepClone()
        {
            var clonedCompany = new Company(Company.Name);
            foreach (var e in Company.Employees)
            {
                var clonedEmployee = new Person(e.Id, e.Name, e.Age, clonedCompany);
                clonedCompany.Employees.Add(clonedEmployee);
            }
            return new Person(Id, Name, Age, clonedCompany);

        }
    }
}
