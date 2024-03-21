namespace Visitor.Classes.VisitorClasses
{
    internal class SerializerManager
    {
        private readonly List<IAccount> _accounts = [];

        public void Add(IAccount account)
        {
            _accounts.Add(account);
        }

        public void Remove(IAccount account)
        {
            _accounts.Remove(account);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var a in _accounts)
            {
                a.Accept(visitor);
            }
        }
    }
}
