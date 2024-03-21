namespace Facade.Classes.Domain.CPU
{
    internal class CPU
    {
        public void Freeze()
        {
            Console.WriteLine("CPU: Freezing...");
        }

        public void Execute()
        {
            Console.WriteLine("CPU: Executing...");
        }
    }
}
