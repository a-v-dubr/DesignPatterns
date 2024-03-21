namespace Command.Classes.Domain
{
    internal class Tv
    {
        public bool IsOn { get; private set; }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Tv is turned off");
        }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Tv is turned on");
        }
    }
}
