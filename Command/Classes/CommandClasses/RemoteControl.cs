namespace Command.Classes.CommandClasses
{
    internal class RemoteControl
    {
        private ICommand? _command;
        public readonly Stack<ICommand> Commands = new();

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void TurnOn()
        {
            if (_command is not null)
            {
                _command.Execute();
                Commands.Push(_command);
            }
        }

        public void TurnOff()
        {
            if (_command is not null)
            {
                _command.Undo();
                Commands.Push(_command);
            }
        }
    }
}
