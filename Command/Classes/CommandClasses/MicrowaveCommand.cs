using Command.Classes.Domain;

namespace Command.Classes.CommandClasses
{
    internal class MicrowaveCommand(Microwave microwave, int time) : ICommand
    {
        private readonly Microwave _microwave = microwave;
        private readonly int _time = time;

        public void Execute()
        {
            _microwave.StartHeating(_time);
            _microwave.StopHeating();
        }

        public void Undo()
        {
            _microwave.StopHeating();
        }
    }
}
