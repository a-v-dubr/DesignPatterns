namespace Observer.Classes
{
    internal class Newspaper(string title) : IObservable
    {
        public Article? NewArticle;
        public string Title { get; } = title;
        public List<Article> Articles { get; } = [];
        public List<IObserver> Observers { get; } = [];

        public void AddNewArticle(Article article)
        {
            NewArticle = article;
            Articles.Add(article);
            Notify();
        }

        public void RegisterObserver(IObserver o)
        {
            Observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            Observers.Remove(o);
        }

        public void Notify()
        {
            if (NewArticle is not null)
            {
                foreach (IObserver o in Observers)
                {
                    o.Update(NewArticle.Title);
                }
            }
            NewArticle = null;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
