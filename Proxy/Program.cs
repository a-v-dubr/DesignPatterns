using Proxy.Classes.Proxy;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ЗАДАЧА:
            // заблокировать посещение запрещённых сайтов при использовании сервиса WebConnection

            // ИМПЛЕМЕНТАЦИЯ PROXY:
            // определён интерфейс, который содержит нужные клиенту методы (в нашем случае единственный метод Connect) 
            // класс proxy реализует этот интерфейс, создаёт объект WebConnection и добавляет собственную логику до или вместо запроса к этому объекту

            var proxy = new WebConnectionProxy();
            proxy.Connect("restricted.com");
            proxy.Connect("allowed.ru");
        }
    }
}
