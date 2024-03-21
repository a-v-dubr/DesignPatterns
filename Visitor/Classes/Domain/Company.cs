using Visitor.Classes.VisitorClasses;

namespace Visitor.Classes.Domain
{
    public class Company : IAccount
    {
        public int Id { get; init; } // оставляю сеттеры, потому что иначе св-ва не сериализуются в xml
        public string Name { get; init; }
        public string TaxpayNumber { get; init; }
        public DateTime RegisteredAt { get; init; }

        public Company(int id, string name, string taxpayNumber, DateTime registerAt)
        {
            Id = id;
            Name = name;
            TaxpayNumber = taxpayNumber;
            RegisteredAt = registerAt;
        }

#pragma warning disable
        private Company() { }
#pragma warning restore

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
