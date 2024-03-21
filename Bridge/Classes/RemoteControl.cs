namespace Bridge.Classes
{
    internal class RemoteControl(IDevice device)
    {
        public IDevice Device { get; private set; } = device;

        public void TurnDeviceOn()
        {
            Device.TurnOn();
        }

        public void TurnDeviceOff()
        {
            Device.TurnOff();
        }

        public void ChangeDevice(IDevice device)
        {
            Device = device;
        }
    }
}
