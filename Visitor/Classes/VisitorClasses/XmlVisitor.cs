using System.Xml.Serialization;
using Visitor.Classes.Domain;

namespace Visitor.Classes.VisitorClasses
{
    internal class XmlVisitor : IVisitor
    {
        public void Visit(Person person)
        {
            string serialized;
            using (var sw = new StringWriter())
            {
                var serializer = new XmlSerializer(typeof(Person));
                serializer.Serialize(sw, person);
                serialized = sw.ToString();
            }
            Console.WriteLine($"Person XML serialization result:\n{serialized}\n");
        }

        public void Visit(Company company)
        {
            string serialized;
            using (var sw = new StringWriter())
            {
                var serializer = new XmlSerializer(typeof(Company));
                serializer.Serialize(sw, company);
                serialized = sw.ToString();
            }
            Console.WriteLine($"Company XML serialization result:\n{serialized}\n");
        }
    }
}
