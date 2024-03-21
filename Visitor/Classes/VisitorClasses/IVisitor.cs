using Visitor.Classes.Domain;

namespace Visitor.Classes.VisitorClasses
{
    public interface IVisitor
    {
        void Visit(Person person);
        void Visit(Company company);
    }
}
