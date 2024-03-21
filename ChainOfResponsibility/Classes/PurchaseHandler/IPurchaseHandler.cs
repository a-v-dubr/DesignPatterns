using ChainOfResponsibility.Classes.Domain;

namespace ChainOfResponsibility.Classes.PurchaseHandler
{
    internal interface IPurchaseHandler
    {
        void ProcessPurchase(Purchase purchase);
        void SetNext(IPurchaseHandler handler);
    }
}
