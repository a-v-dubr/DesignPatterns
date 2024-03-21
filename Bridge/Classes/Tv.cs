namespace Bridge.Classes
{
    internal class Tv : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Tv is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Tv is off");
        }
    }
}
