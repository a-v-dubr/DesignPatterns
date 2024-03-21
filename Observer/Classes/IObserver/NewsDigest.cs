namespace Observer.Classes
{
    internal class NewsDigest : IObserver
    {
        public List<IObservable> Magazines { get; } = [];

        public void AddMagazine(IObservable magazine)
        {
            if (!Magazines.Contains(magazine))
            {
                Magazines.Add(magazine);
                magazine.RegisterObserver(this);
            }
        }

        public void Update(string message)
        {
            Console.WriteLine($"New article '{message}' is available in digest");
        }
    }
}
