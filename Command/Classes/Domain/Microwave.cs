namespace Command.Classes.Domain
{
    internal class Microwave
    {
        public void StartHeating(int time)
        {
            Console.WriteLine("Microwave heats food");
            Task.Delay(time).GetAwaiter().GetResult();
        }

        public void StopHeating()
        {
            Console.WriteLine("Microwave is turned off");
        }
    }
}
