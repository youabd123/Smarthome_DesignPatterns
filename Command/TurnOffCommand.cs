namespace Smarthome
{
    public class TurnOffCommand : ICommand
    {
        private Lamp _lamp;

        public TurnOffCommand(Lamp lamp)
        {
            _lamp = lamp;
        }

        public void Execute()
        {
            _lamp.TurnOff();
        }
    }
}
