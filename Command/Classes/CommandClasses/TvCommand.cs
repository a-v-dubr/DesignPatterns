using Command.Classes.Domain;

namespace Command.Classes.CommandClasses
{
    internal class TvCommand(Tv tv) : ICommand
    {
        private readonly Tv _tv = tv;

        public void Execute()
        {
            _tv.TurnOn();
        }

        public void Undo()
        {
            _tv.TurnOff();
        }
    }
}
