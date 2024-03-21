namespace Observer.Classes
{
    internal class Subscriber : IObserver
    {
        public string Name { get; }
        public IObservable Magazine { get; }

        public Subscriber(string name, IObservable magazine)
        {
            Name = name;
            Magazine = magazine;
            magazine.RegisterObserver(this);
        }

        public void Update(string message)
        {
            Console.WriteLine($"Hi, {Name}! New article is available: '{message}'");
        }
    }
}
