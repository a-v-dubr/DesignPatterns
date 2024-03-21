using Observer.Classes;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ЗАДАЧА: 
            // создать механизм уведомлений об обновлениях контента журнала для подписчиков журнала и новостного дайджеста

            // ИМПЛЕМЕНТАЦИЯ OBSERVER:
            // классы-подписчики реализуют IObserver, класс журнала - IObservable
            // конкретная имплементация подписчиков и издателей не имеет значения: каждый издатель имеет собственную имплементацию
            // Notify(), каждый подписчик - аналогично Update()

            var magazine = new Newspaper("The Times");

            var subscriber1 = new Subscriber("John", magazine);
            var subscriber2 = new NewsDigest();
            subscriber2.AddMagazine(magazine);

            magazine.AddNewArticle(new Article("How British cocaine users are funding Albania's mini Dubai", default!));
        }
    }
}
