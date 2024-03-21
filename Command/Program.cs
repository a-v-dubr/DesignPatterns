using Command.Classes.CommandClasses;
using Command.Classes.Domain;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ЗАДАЧА: 
            // реализовать пульт с опциями включения и выключения, совместимый с разными устройствами (ТВ и микроволновка),
            // и возможность добавлять любые новые устройства

            // ИМПЛЕМЕНТАЦИЯ COMMAND:
            // для управления каждым устройством существуют классы, реализующие ICommand
            // RemoteControl - класс-invoker, управляющий вызовом команд и ничего не знающий ни о конкретных командах и их параметрах,
            // ни об объектах, которым адресованы команды; параметры команд могут быть любыми и зависят только от классов, к которым они применены

            var remote = new RemoteControl();
            remote.SetCommand(new TvCommand(new Tv()));
            remote.TurnOn();

            remote.SetCommand(new MicrowaveCommand(new Microwave(), 1000));
            remote.TurnOn();
        }
    }
}
