using Bridge.Classes;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ЗАДАЧА:
            // реализовать функционал пульта и управляемых им устройств таким образом, чтобы можно было добавлять новые устройства или
            // вариации пульта независимо друг от друга

            // ИМПЛЕМЕНТАЦИЯ BRIDGE:
            // определён интерфейс устройств (реализация) IDevice и класс пульта RemoteControl (абстракция)
            // клиентский код передаёт объекту RemoteControl конкретный тип IDevice и далее работает только с методами RemoteControl
            // при необходимости под разные типы IDevice могут быть определены конкретные абстракции, наследующие RemoteControl

            var remote = new RemoteControl(new Tv());
            remote.TurnDeviceOn();

            remote.ChangeDevice(new Radio());
            remote.TurnDeviceOn();
        }
    }
}
