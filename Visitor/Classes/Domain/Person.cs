using Visitor.Classes.VisitorClasses;

namespace Visitor.Classes.Domain
{
    public class Person : IAccount
    {
        public int Id { get; init; } // оставляю сеттеры, потому что иначе св-ва не сериализуются в xml
        public string Name { get; init; }
        public string Email { get; init; }
        public DateTime RegisteredAt { get; init; }

        public Person(int id, string name, string email, DateTime registerAt)
        {
            Id = id;
            Name = name;
            Email = email;
            RegisteredAt = registerAt;
        }

#pragma warning disable
        private Person() { }
#pragma warning restore

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
