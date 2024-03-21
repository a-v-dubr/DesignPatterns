using Singleton.Classes;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ЗАДАЧА: 
            // создать логгер, который будет гарантирует, что информация будет логироваться одинаковым образом
            // и храниться в единственном выделенном месте месте

            // ИМПЛЕМЕНТАЦИЯ SINGLETON:
            // приватный к-р, статический метод доступа к объекту, public свойство с записями логов, к-рые могут быть сериализованы или сохранены и переданы иначе

            var logger = Logger.GetInstance();
            logger.Log("session started");
            while (true)
            {
                logger.Log($"console input: {Console.ReadLine()}");
            }
        }
    }
}
