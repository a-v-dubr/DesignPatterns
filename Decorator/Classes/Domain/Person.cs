namespace Decorator.Classes.Domain
{
    internal class Person(string name, string email, int phone)
    {
        public string Name { get; } = name;
        public string Email { get; } = email;
        public int Phone { get; } = phone;
    }
}
