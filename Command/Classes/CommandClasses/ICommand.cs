namespace Command.Classes.CommandClasses
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
