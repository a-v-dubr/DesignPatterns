using Newtonsoft.Json;
using Visitor.Classes.Domain;

namespace Visitor.Classes.VisitorClasses
{
    internal class JsonVisitor : IVisitor
    {
        public void Visit(Person person)
        {
            string serialized = JsonConvert.SerializeObject(person);
            Console.WriteLine($"Person JSON serialization result:\n{serialized}\n");
        }

        public void Visit(Company company)
        {
            string serialized = JsonConvert.SerializeObject(company);
            Console.WriteLine($"Company JSON serialization result:\n{serialized}\n");
        }
    }
}
