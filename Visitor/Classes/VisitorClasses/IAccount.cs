namespace Visitor.Classes.VisitorClasses
{
    internal interface IAccount
    {
        void Accept(IVisitor visitor);
    }
}
